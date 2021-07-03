
namespace Recorder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.b_SaveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxVideo = new System.Windows.Forms.ToolStripComboBox();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxAudio = new System.Windows.Forms.ToolStripComboBox();
            this.b_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.pBoxCam = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_Record = new System.Windows.Forms.Button();
            this.b_Start = new System.Windows.Forms.Button();
            this.mStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_SaveTo,
            this.toolStripMenuItem1,
            this.b_Exit});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(484, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // b_SaveTo
            // 
            this.b_SaveTo.Name = "b_SaveTo";
            this.b_SaveTo.Size = new System.Drawing.Size(58, 20);
            this.b_SaveTo.Text = "Save To";
            this.b_SaveTo.Click += new System.EventHandler(this.b_SaveTo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.audioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Setting";
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBoxVideo});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.videoToolStripMenuItem.Text = "Video";
            // 
            // cBoxVideo
            // 
            this.cBoxVideo.Name = "cBoxVideo";
            this.cBoxVideo.Size = new System.Drawing.Size(121, 23);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBoxAudio});
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // cBoxAudio
            // 
            this.cBoxAudio.Name = "cBoxAudio";
            this.cBoxAudio.Size = new System.Drawing.Size(121, 23);
            // 
            // b_Exit
            // 
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(38, 20);
            this.b_Exit.Text = "Exit";
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // pBoxCam
            // 
            this.pBoxCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxCam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pBoxCam.Location = new System.Drawing.Point(0, 28);
            this.pBoxCam.Name = "pBoxCam";
            this.pBoxCam.Size = new System.Drawing.Size(484, 362);
            this.pBoxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxCam.TabIndex = 1;
            this.pBoxCam.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.b_Record);
            this.panel1.Controls.Add(this.b_Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 63);
            this.panel1.TabIndex = 2;
            // 
            // b_Record
            // 
            this.b_Record.Location = new System.Drawing.Point(84, 3);
            this.b_Record.Name = "b_Record";
            this.b_Record.Size = new System.Drawing.Size(75, 57);
            this.b_Record.TabIndex = 1;
            this.b_Record.Text = "RECORD";
            this.b_Record.UseVisualStyleBackColor = true;
            this.b_Record.Click += new System.EventHandler(this.b_Record_Click);
            // 
            // b_Start
            // 
            this.b_Start.Location = new System.Drawing.Point(3, 3);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(75, 57);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "START";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBoxCam);
            this.Controls.Add(this.mStrip);
            this.MainMenuStrip = this.mStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem b_SaveTo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBoxVideo;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBoxAudio;
        private System.Windows.Forms.ToolStripMenuItem b_Exit;
        private System.Windows.Forms.PictureBox pBoxCam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_Record;
        private System.Windows.Forms.Button b_Start;
    }
}

