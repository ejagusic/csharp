
namespace MusicPlayer.Forms
{
    partial class PlaylistForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstTracks;
        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Button btnRemoveTrack;
        private System.Windows.Forms.Button btnSavePlaylist;
        private System.Windows.Forms.Button btnLoadPlaylist;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstTracks = new ListBox();
            btnAddTrack = new Button();
            btnRemoveTrack = new Button();
            btnSavePlaylist = new Button();
            btnLoadPlaylist = new Button();
            btnBack = new Button();
            SuspendLayout();

            // 
            // lstTracks
            // 
            lstTracks.FormattingEnabled = true;
            lstTracks.Location = new Point(20, 20);
            lstTracks.Name = "lstTracks";
            lstTracks.Size = new Size(300, 124);
            lstTracks.TabIndex = 0;
            lstTracks.SelectedIndexChanged += lstTracks_SelectedIndexChanged;
            // 
            // btnAddTrack
            // 
            btnAddTrack.Location = new Point(139, 150);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(100, 25);
            btnAddTrack.TabIndex = 1;
            btnAddTrack.Text = "Add Track";
            btnAddTrack.UseVisualStyleBackColor = true;
            btnAddTrack.Click += btnAddTrack_Click;
            // 
            // btnRemoveTrack
            // 
            btnRemoveTrack.Location = new Point(139, 181);
            btnRemoveTrack.Name = "btnRemoveTrack";
            btnRemoveTrack.Size = new Size(100, 25);
            btnRemoveTrack.TabIndex = 2;
            btnRemoveTrack.Text = "Remove Track";
            btnRemoveTrack.UseVisualStyleBackColor = true;
            btnRemoveTrack.Click += btnRemoveTrack_Click;
            // 
            // btnSavePlaylist
            // 
            btnSavePlaylist.Location = new Point(20, 150);
            btnSavePlaylist.Name = "btnSavePlaylist";
            btnSavePlaylist.Size = new Size(104, 25);
            btnSavePlaylist.TabIndex = 3;
            btnSavePlaylist.Text = "Save Playlist";
            btnSavePlaylist.UseVisualStyleBackColor = true;
            btnSavePlaylist.Click += btnSavePlaylist_Click;
            // 
            // btnLoadPlaylist
            // 
            btnLoadPlaylist.Location = new Point(20, 181);
            btnLoadPlaylist.Name = "btnLoadPlaylist";
            btnLoadPlaylist.Size = new Size(104, 25);
            btnLoadPlaylist.TabIndex = 4;
            btnLoadPlaylist.Text = "Load Playlist";
            btnLoadPlaylist.UseVisualStyleBackColor = true;
            btnLoadPlaylist.Click += btnLoadPlaylist_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(245, 150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 25);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PlaylistForm
            // 
            ClientSize = new Size(342, 220);
            Controls.Add(btnBack);
            Controls.Add(btnLoadPlaylist);
            Controls.Add(btnSavePlaylist);
            Controls.Add(btnRemoveTrack);
            Controls.Add(btnAddTrack);
            Controls.Add(lstTracks);
            Name = "PlaylistForm";
            Text = "Playlist";
            ResumeLayout(false);
        }

        private void lstTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
