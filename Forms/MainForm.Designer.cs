namespace MusicPlayer.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnOpenPlaylist;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblTrackInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Panel panelVisualizer;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnPlay = new Button();
            btnPause = new Button();
            btnStop = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnOpenPlaylist = new Button();
            btnAbout = new Button();
            lblTrackInfo = new Label();
            progressBar = new ProgressBar();
            lblTime = new Label();
            trackBarVolume = new TrackBar();
            panelVisualizer = new Panel();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(169, 93);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(60, 24);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play ▶";
            btnPlay.TextAlign = ContentAlignment.TopCenter;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(169, 123);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(60, 24);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause ❚❚";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(169, 153);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(60, 24);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop ◼";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(235, 93);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(78, 24);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next ▷";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(85, 93);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(78, 24);
            btnPrevious.TabIndex = 4;
            btnPrevious.Text = "◁ Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnOpenPlaylist
            // 
            btnOpenPlaylist.Location = new Point(6, 6);
            btnOpenPlaylist.Name = "btnOpenPlaylist";
            btnOpenPlaylist.Size = new Size(102, 23);
            btnOpenPlaylist.TabIndex = 5;
            btnOpenPlaylist.Text = "Open Playlist";
            btnOpenPlaylist.UseVisualStyleBackColor = true;
            btnOpenPlaylist.Click += btnOpenPlaylist_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(114, 6);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(68, 23);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // lblTrackInfo
            // 
            lblTrackInfo.AutoSize = true;
            lblTrackInfo.Location = new Point(30, 42);
            lblTrackInfo.Name = "lblTrackInfo";
            lblTrackInfo.Size = new Size(59, 15);
            lblTrackInfo.TabIndex = 10;
            lblTrackInfo.Text = "Track Info";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(30, 60);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(340, 10);
            progressBar.TabIndex = 8;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(298, 75);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 15);
            lblTime.TabIndex = 9;
            lblTime.Text = "00:00 / 00:00";
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(6, 137);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(120, 45);
            trackBarVolume.TabIndex = 11;
            trackBarVolume.TickFrequency = 10;
            trackBarVolume.Value = 80;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // panelVisualizer
            // 
            panelVisualizer.Location = new Point(235, 123);
            panelVisualizer.Name = "panelVisualizer";
            panelVisualizer.Size = new Size(153, 59);
            panelVisualizer.TabIndex = 12;
            panelVisualizer.Paint += panelVisualizer_Paint;
            // 
            // MainForm
            // 
            ClientSize = new Size(400, 194);
            Controls.Add(panelVisualizer);
            Controls.Add(trackBarVolume);
            Controls.Add(progressBar);
            Controls.Add(lblTime);
            Controls.Add(lblTrackInfo);
            Controls.Add(btnAbout);
            Controls.Add(btnOpenPlaylist);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Name = "MainForm";
            Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
