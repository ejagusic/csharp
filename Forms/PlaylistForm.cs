using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer.Models;
using MusicPlayer.Helpers;

namespace MusicPlayer.Forms
{
    public partial class PlaylistForm : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Playlist Playlist { get; private set; }

        public PlaylistForm(Playlist playlist)
        {
            InitializeComponent();
            Playlist = playlist;
            RefreshTrackList();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void RefreshTrackList()
        {
            lstTracks.Items.Clear();
            foreach (var track in Playlist.Tracks)
                lstTracks.Items.Add(track.Title);
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var track = new Track
                    {
                        Title = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName),
                        Artist = "Unknown",
                        FilePath = ofd.FileName
                    };
                    Playlist.Tracks.Add(track);
                    RefreshTrackList();
                }
            }
        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            if (lstTracks.SelectedIndex >= 0)
            {
                Playlist.Tracks.RemoveAt(lstTracks.SelectedIndex);
                RefreshTrackList();
            }
        }
        private async void btnSavePlaylist_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Playlist files (*.mpl)|*.mpl";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    await Task.Run(() => SerializationHelper.SavePlaylist(Playlist, sfd.FileName));
                    MessageBox.Show("Playlist saved successfully.", "Save Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private async void btnLoadPlaylist_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Playlist files (*.mpl)|*.mpl";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var loadedPlaylist = await Task.Run(() => SerializationHelper.LoadPlaylist(ofd.FileName));
                    Playlist = loadedPlaylist;
                    RefreshTrackList();
                    MessageBox.Show("Playlist loaded successfully.", "Load Playlist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
