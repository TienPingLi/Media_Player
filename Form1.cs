using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            wmpVideo.uiMode = "none";
            wmpVideo.stretchToFit = true;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter =
                "WMV files (*.wmv)|*.wmv|" +
                "MP4 files (*.mp4)|*.mp4|" +
                "AVI files (*.avi)|*.avi|" +
                "MP3 files (*.mp3)|*.mp3|" +
                "WAV files (*.wav)|*.wav|" +
                "All files (*.*)|*.*";

            ofd.Title = "選擇多媒體檔案";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(wmpVideo.URL))
            {
                MessageBox.Show(
                    "請先選擇要播放的多媒體檔案。",
                    "提醒",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            wmpVideo.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "確定要關閉應用程式嗎？",
                "關閉確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            wmpVideo.Ctlcontrols.stop();
        }
    }
}