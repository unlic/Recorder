using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Accord.DirectSound;
using Accord.Video.DirectShow;
using Accord.Video.FFMPEG;
using Accord.Audio;
using System.Threading;

namespace Recorder
{
    public partial class Form1 : Form
    {
        string path="";       
        FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        AudioDeviceCollection audioInDevices = new AudioDeviceCollection(AudioDeviceCategory.Capture);       
        public VideoCaptureDevice videoSource;
        AudioCaptureDevice audioInSource;           
        List<AudioDeviceInfo> audioInDevicesInfo = new List<AudioDeviceInfo>();
        VideoFileWriter writer = new VideoFileWriter();
        private DateTime? _firstFrame;
        private TimeSpan _firstSignal;   
        
        bool newSig, newBit, isRecord, bStartRecord = false, bStartShow = false;
        Bitmap bitmap;
        Signal signal;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_SaveTo_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
            {
                folder.ShowDialog();
                path = folder.SelectedPath+"/";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_Device();
        }

        //Получаем список устройст и записываем их в ComboBox
        private void list_Device()
        {
            foreach (var device in videoDevices)
            {
                cBoxVideo.Items.Add(device.Name);
            }
            foreach (var device in audioInDevices)
            {
                cBoxAudio.Items.Add(device.ToString());
                audioInDevicesInfo.Add(device);
            }
            cBoxVideo.SelectedIndex = Convert.ToInt32(0);
            cBoxAudio.SelectedIndex = Convert.ToInt32(0);
        }


        //Начинаем прослушивать устройста аудио и видео
        private void b_Start_Click(object sender, EventArgs e)
        {
            if (!bStartShow)
            {
                bStartShow = true;
                b_Start.Text = "STOP";
                videoSource = new VideoCaptureDevice(videoDevices[cBoxVideo.SelectedIndex].MonikerString);
                videoSource.NewFrame += new Accord.Video.NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
                audioInSource = new AudioCaptureDevice(audioInDevicesInfo[cBoxAudio.SelectedIndex]);
                audioInSource.NewFrame += AudioInSource_NewFrame;              
                audioInSource.Start();
               
            }
            else
            {
                bStartShow = false;
                b_Start.Text = "START";
                videoSource.SignalToStop();
                audioInSource.SignalToStop();             

            }
        }

        //Собитие оброботки нового кадра с аудиоустройства
        private void AudioInSource_NewFrame(object sender, NewFrameEventArgs e)
        {
            signal = e.Signal;
            newSig = true;
        }
        //Собитие оброботки нового кадра с видеоустройства
        private void VideoSource_NewFrame(object sender, Accord.Video.NewFrameEventArgs eventArgs)
        {
            pBoxCam.Image = (Bitmap)eventArgs.Frame.Clone();
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            newBit = true;
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                if (isRecord == true)
                {
                    isRecord = false;
                }
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    audioInSource.SignalToStop();
                }
            }
        }

        private void b_Record_Click(object sender, EventArgs e)
        {
            if (!bStartRecord)
            {
                b_Record.Text = "STOP RECORDING";
                Thread recording = new Thread(new ThreadStart(rec_Start));
                isRecord = true;
                writer = new VideoFileWriter
                {
                    Width = bitmap.Width,
                    Height = bitmap.Height,
                    AudioCodec = AudioCodec.Aac,
                    VideoCodec = VideoCodec.Mpeg4,
                    FrameRate =30,
                    AudioBitRate = 44100,
                    AudioLayout = AudioLayout.Mono,
                    BitRate = 600000,
                    SampleRate = signal.SampleRate,
                    FrameSize = 4096
                };                
                writer.Open(path+"video.avi");
                isRecord = true;
                recording.Start();
                bStartRecord = true;
            }
            else
            {
                b_Record.Text = "RECORD";
                isRecord = false;
                bStartRecord = false;
            }
           

        }
        private void rec_Start()
        {
            //запис первих кадров
            writer.WriteVideoFrame(bitmap);
            writer.WriteAudioFrame(signal);   
            //Определение длины кадра
            _firstFrame = DateTime.Now;
            _firstSignal = signal.Duration;
            newSig = false; newBit = false;
           
            //Запис 
            while (isRecord)
            {
                if (newSig)
                {
                    _firstSignal += signal.Duration;
                    writer.WriteAudioFrame(signal, _firstSignal);
                    newSig = false;
                    
                }
                if (newBit)
                {
                    try
                    {
                        writer.WriteVideoFrame(bitmap, DateTime.Now - _firstFrame.Value);
                        newBit = false;
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }

                }

            }
            //завершение записи
            writer.Close();
            writer.Dispose();          
            MessageBox.Show("Stop Recording");

        }
        private void b_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
