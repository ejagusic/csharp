using System;
using System.Windows.Forms;
using MusicPlayer.Models;
using MusicPlayer.Helpers;
using MusicPlayer.Forms;

namespace MusicPlayer.Forms
{
    public partial class MainForm : Form
    {
        private Playlist currentPlaylist;
        private int currentTrackIndex = 0;
        private AudioPlayer audioPlayer = new AudioPlayer();
        private System.Windows.Forms.Timer timerProgress = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer visualizerTimer = new System.Windows.Forms.Timer();
        private Random rand = new Random();


        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            currentPlaylist = new Playlist("Default");
            lblTrackInfo.Text = "No track loaded.";
            timerProgress.Interval = 500;
            timerProgress.Tick += timerProgress_Tick;
            audioPlayer.Volume = trackBarVolume.Value / 100f;
            visualizerTimer.Interval = 50;
            visualizerTimer.Tick += VisualizerTimer_Tick;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (currentPlaylist.Tracks.Count == 0)
            {
                MessageBox.Show("No tracks in playlist.");
                return;
            }
            var track = currentPlaylist.Tracks[currentTrackIndex];
            audioPlayer.Play(track.FilePath);
            lblTrackInfo.Text = track.Title;
            timerProgress.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            audioPlayer.Pause();
            visualizerTimer.Stop();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            audioPlayer.Stop();
            timerProgress.Stop();
            progressBar.Value = 0;
            visualizerTimer.Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPlaylist.Tracks.Count == 0) return;
            currentTrackIndex = (currentTrackIndex + 1) % currentPlaylist.Tracks.Count;
            btnPlay_Click(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPlaylist.Tracks.Count == 0) return;
            currentTrackIndex = (currentTrackIndex - 1 + currentPlaylist.Tracks.Count) % currentPlaylist.Tracks.Count;
            btnPlay_Click(sender, e);
        }

        private void btnOpenPlaylist_Click(object sender, EventArgs e)
        {
            using (var pf = new PlaylistForm(currentPlaylist))
            {
                if (pf.ShowDialog() == DialogResult.OK)
                {
                    currentPlaylist = pf.Playlist;
                    currentTrackIndex = 0;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var af = new AboutForm())
            {
                af.ShowDialog();
            }
        }

        private void timerProgress_Tick(object? sender, EventArgs e)
        {
            int percent = audioPlayer.GetProgressPercent();
            progressBar.Value = Math.Min(percent, 100);

            var audioFileField = typeof(AudioPlayer)
                .GetField("audioFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var audioFile = audioFileField?.GetValue(audioPlayer) as NAudio.Wave.AudioFileReader;

            if (audioFile != null)
            {
                var current = audioFile.CurrentTime;
                var total = audioFile.TotalTime;
                lblTime.Text = $"{(int)current.TotalMinutes:D2}:{current.Seconds:D2} / {(int)total.TotalMinutes:D2}:{total.Seconds:D2}";
            }
            else
            {
                lblTime.Text = "00:00 / 00:00";
            }

            if (!audioPlayer.IsPlaying && percent >= 100)
            {
                timerProgress.Stop();
                progressBar.Value = 0;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            audioPlayer.Volume = trackBarVolume.Value / 100f;
        }

        private int[] visualizerValues = new int[16];

        private void panelVisualizer_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            int blockWidth = panelVisualizer.Width / visualizerValues.Length;
            for (int i = 0; i < visualizerValues.Length; i++)
            {
                int blockHeight = visualizerValues[i];
                Rectangle rect = new Rectangle(
                    i * blockWidth,
                    panelVisualizer.Height - blockHeight,
                    blockWidth - 2,
                    blockHeight);
                g.FillRectangle(Brushes.Cyan, rect);
            }
        }

        private void VisualizerTimer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i < visualizerValues.Length; i++)
            {
                visualizerValues[i] = rand.Next(5, panelVisualizer.Height);
            }
            panelVisualizer.Invalidate();
        }


    }
}
