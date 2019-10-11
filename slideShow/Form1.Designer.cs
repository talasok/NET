namespace slideShow
{
    partial class Slide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slide));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.showImgLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.showImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.showImg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // showImgLayout
            // 
            this.showImgLayout.AutoScroll = true;
            this.showImgLayout.Location = new System.Drawing.Point(12, 367);
            this.showImgLayout.Name = "showImgLayout";
            this.showImgLayout.Size = new System.Drawing.Size(621, 100);
            this.showImgLayout.TabIndex = 5;
            // 
            // btnFile
            // 
            this.btnFile.AutoSize = true;
            this.btnFile.Image = global::slideShow.Properties.Resources.iconfinder_folder_add_216217;
            this.btnFile.Location = new System.Drawing.Point(602, 477);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(31, 30);
            this.btnFile.TabIndex = 4;
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnRun
            // 
            this.btnRun.AutoSize = true;
            this.btnRun.Image = global::slideShow.Properties.Resources.iconfinder_media_play_216313;
            this.btnRun.Location = new System.Drawing.Point(523, 477);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(30, 30);
            this.btnRun.TabIndex = 3;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Image = global::slideShow.Properties.Resources.iconfinder_chevron_left_216147;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNext.Location = new System.Drawing.Point(562, 477);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.Image = global::slideShow.Properties.Resources.iconfinder_chevron_left_216147__1_;
            this.btnPrev.Location = new System.Drawing.Point(487, 477);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // showImg
            // 
            this.showImg.Location = new System.Drawing.Point(1, 1);
            this.showImg.Name = "showImg";
            this.showImg.Size = new System.Drawing.Size(640, 360);
            this.showImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showImg.TabIndex = 0;
            this.showImg.TabStop = false;
            // 
            // Slide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 511);
            this.Controls.Add(this.showImgLayout);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.showImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Slide";
            this.Text = "Slide";
            this.Load += new System.EventHandler(this.Slide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox showImg;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FlowLayoutPanel showImgLayout;
    }
}

