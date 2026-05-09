namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel palButton;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.palButton = new System.Windows.Forms.Panel();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.palButton.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(30, 30, 42);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(820, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "多媒體播放器";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState =
                ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.TabIndex = 1;
            //this.wmpVideo.uiMode = "none";
            //this.wmpVideo.stretchToFit = true;

            // 
            // palButton
            // 
            this.palButton.BackColor = System.Drawing.Color.FromArgb(38, 38, 52);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnEnd);
            this.palButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location = new System.Drawing.Point(0, 515);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(820, 75);
            this.palButton.TabIndex = 2;

            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnBrowser.FlatAppearance.BorderSize = 0;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.btnBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBrowser.Location = new System.Drawing.Point(40, 18);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(110, 40);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);

            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(60, 160, 100);
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(180, 18);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);

            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(220, 150, 60);
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(320, 18);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 40);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);

            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(190, 70, 70);
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(460, 18);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 40);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(90, 90, 110);
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(600, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(110, 40);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(24, 24, 36);
            this.ClientSize = new System.Drawing.Size(820, 590);
            this.Controls.Add(this.wmpVideo);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多媒體播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.palButton.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}