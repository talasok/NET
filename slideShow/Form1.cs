﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace slideShow
{
    public partial class Slide : Form
    {
        string Dirpath;
        int imgindex=0;
        String[] list= new string[100];
        int index=0;
        Boolean check = false;
        PictureBox layoutImg;
        public Slide()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imgindex < list.Length - 1 || imgindex < index-1)
            {
                imgindex += 1;
                showImg.ImageLocation = list[imgindex].ToString();
                if (imgindex == list.Length - 1 || imgindex == index-1)
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
                if (imgindex < list.Length - 1 ||imgindex < index-1)
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
            DialogResult dr = folderBrowserDialog1.ShowDialog();   
            if (dr != DialogResult.Cancel)
            {
                Dirpath = folderBrowserDialog1.SelectedPath;
                list = Directory.GetFiles(Dirpath, "*.jpg");
            }
            if(list!=null)
            {
                load_open();
                Load_layout();
                btnPrev.Enabled = false;
                btnNext.Enabled = btnRun.Enabled = true;
                btnAdd.Enabled = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNext.PerformClick();
        }
        private void load_open()
        {
            if(list!=null && list.Length > 0)
            {
                showImg.ImageLocation = list[imgindex].ToString();
            }
            else
            {
                showImg.ImageLocation = null;
                showImg.Refresh();
                MessageBox.Show("thư mục k chứa ảnh");
            }
        }
        private void Load_layout()
        {
            if (showImgLayout != null)
            {
                showImgLayout.Controls.Clear();
            }
            foreach (string ds in list)
            {
                layoutImg = new PictureBox();
                layoutImg.SizeMode = PictureBoxSizeMode.StretchImage;
                layoutImg.ImageLocation = ds;
                showImgLayout.Controls.Add(layoutImg);
            }
        }

        private void Slide_Load(object sender, EventArgs e)
        {
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnRun.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "file anh (*.jpg, *.png)|*.png;*.jpg";
            fileDialog.Title = "chọn ảnh ";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;
                list[index] = fileName;
                index++;
                Load_layout();
                load_open();
            }
            if (index != 0)
            {
                btnFile.Enabled = false;
                btnRun.Enabled = btnNext.Enabled = true;
            }
        }
    }
}
