using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slideShow
{
    public partial class Slide : Form
    {
        string Dirpath;
        int imgindex=0;
        String[] list;
        Boolean check = false;
        PictureBox layoutImg;
        public Slide()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imgindex < list.Length - 1)
            {
                imgindex += 1;
                showImg.ImageLocation = list[imgindex].ToString();
                if (imgindex == list.Length - 1)
                {
                    btnNext.Enabled = false;
                    check = false;
                    btnRun.Image = Image.FromFile("icon/iconfinder_media-play_216313.png");
                    timer1.Stop();
                }
                if (imgindex > 0)
                    btnPrev.Enabled = true;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (imgindex > 0)
            {
                imgindex -= 1;
                showImg.ImageLocation = list[imgindex].ToString();
                if (imgindex == 0)
                {
                    btnPrev.Enabled = false;
                }
                if (imgindex < list.Length - 1)
                    btnNext.Enabled = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(check == false)
            {
                check = true;
                btnRun.Image = Image.FromFile("icon/iconfinder_media-pause_216309.png");
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                check = false;
                btnRun.Image = Image.FromFile("icon/iconfinder_media-play_216313.png");
                timer1.Stop();
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            list = null;
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                Dirpath = folderBrowserDialog1.SelectedPath;
                list = Directory.GetFiles(Dirpath, "*.jpg");
            }
            btnPrev.Enabled = true;
            btnNext.Enabled = btnRun.Enabled = true;
            if(list.Length > 0)
            {
                load_open();
                Load_layout();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }
        private void load_open()
        {
            showImg.ImageLocation = list[imgindex].ToString();
        }
        private void Load_layout()
        {
            foreach(string ds in list)
            {
                layoutImg = new PictureBox();
                layoutImg.SizeMode = PictureBoxSizeMode.StretchImage;
                layoutImg.ImageLocation = ds.ToString();
                showImgLayout.Controls.Add(layoutImg);
            }
        }
    }
}
