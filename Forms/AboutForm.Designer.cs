namespace MusicPlayer.Forms
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAbout = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Location = new Point(59, 21);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(164, 15);
            lblAbout.TabIndex = 0;
            lblAbout.Text = "Music Player by Enzzo Jagušić";
            lblAbout.Click += lblAbout_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(86, 45);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 24);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AboutForm
            // 
            ClientSize = new Size(280, 81);
            Controls.Add(btnClose);
            Controls.Add(lblAbout);
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
