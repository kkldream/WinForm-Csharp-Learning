namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucBtnImg1 = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBar_year = new HZH_Controls.Controls.UCTrackBar();
            this.ucThermometer_global = new HZH_Controls.Controls.UCThermometer();
            this.ucSplitLabel_yearsLeft = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel_yearsRight = new HZH_Controls.Controls.UCSplitLabel();
            this.label_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucProcessWave_co2 = new HZH_Controls.Controls.UCProcessWave();
            this.label_co2 = new System.Windows.Forms.Label();
            this.ucProcessWave_ch4 = new HZH_Controls.Controls.UCProcessWave();
            this.label1 = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.ucRollText1 = new HZH_Controls.Controls.UCRollText();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBtnImg1
            // 
            this.ucBtnImg1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImg1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImg1.BtnFont = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucBtnImg1.BtnForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucBtnImg1.BtnText = "";
            this.ucBtnImg1.ConerRadius = 60;
            this.ucBtnImg1.EnabledMouseEffect = true;
            this.ucBtnImg1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ucBtnImg1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImg1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucBtnImg1.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg1.Image")));
            this.ucBtnImg1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg1.ImageFontIcons = null;
            this.ucBtnImg1.IsRadius = true;
            this.ucBtnImg1.IsShowRect = false;
            this.ucBtnImg1.IsShowTips = false;
            this.ucBtnImg1.Location = new System.Drawing.Point(724, 76);
            this.ucBtnImg1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImg1.Name = "ucBtnImg1";
            this.ucBtnImg1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnImg1.RectWidth = 1;
            this.ucBtnImg1.Size = new System.Drawing.Size(64, 59);
            this.ucBtnImg1.TabIndex = 0;
            this.ucBtnImg1.TabStop = false;
            this.ucBtnImg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImg1.TipsText = "";
            this.ucBtnImg1.BtnClick += new System.EventHandler(this.ucBtnImg1_BtnClick);
            // 
            // ucTrackBar_year
            // 
            this.ucTrackBar_year.DcimalDigits = 2;
            this.ucTrackBar_year.IsShowTips = true;
            this.ucTrackBar_year.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_year.LineWidth = 20F;
            this.ucTrackBar_year.Location = new System.Drawing.Point(34, 400);
            this.ucTrackBar_year.MaxValue = 2020F;
            this.ucTrackBar_year.MinValue = 2000F;
            this.ucTrackBar_year.Name = "ucTrackBar_year";
            this.ucTrackBar_year.Size = new System.Drawing.Size(735, 48);
            this.ucTrackBar_year.TabIndex = 1;
            this.ucTrackBar_year.Text = "ucTrackBar_year";
            this.ucTrackBar_year.TipsFormat = "0.年";
            this.ucTrackBar_year.Value = 2000F;
            this.ucTrackBar_year.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTrackBar_year.ValueChanged += new System.EventHandler(this.ucTrackBar_year_ValueChanged);
            // 
            // ucThermometer_global
            // 
            this.ucThermometer_global.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucThermometer_global.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer_global.Location = new System.Drawing.Point(717, 147);
            this.ucThermometer_global.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ucThermometer_global.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucThermometer_global.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer_global.Name = "ucThermometer_global";
            this.ucThermometer_global.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.None;
            this.ucThermometer_global.Size = new System.Drawing.Size(82, 246);
            this.ucThermometer_global.SplitCount = 2;
            this.ucThermometer_global.TabIndex = 2;
            this.ucThermometer_global.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ucThermometer_global.Click += new System.EventHandler(this.ucThermometer_global_Click);
            // 
            // ucSplitLabel_yearsLeft
            // 
            this.ucSplitLabel_yearsLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ucSplitLabel_yearsLeft.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_yearsLeft.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_yearsLeft.Location = new System.Drawing.Point(12, 451);
            this.ucSplitLabel_yearsLeft.Margin = new System.Windows.Forms.Padding(0);
            this.ucSplitLabel_yearsLeft.MaximumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsLeft.MinimumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsLeft.Name = "ucSplitLabel_yearsLeft";
            this.ucSplitLabel_yearsLeft.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_yearsLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucSplitLabel_yearsLeft.Size = new System.Drawing.Size(81, 37);
            this.ucSplitLabel_yearsLeft.TabIndex = 3;
            this.ucSplitLabel_yearsLeft.Text = "2000";
            this.ucSplitLabel_yearsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucSplitLabel_yearsRight
            // 
            this.ucSplitLabel_yearsRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ucSplitLabel_yearsRight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_yearsRight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_yearsRight.Location = new System.Drawing.Point(689, 451);
            this.ucSplitLabel_yearsRight.Margin = new System.Windows.Forms.Padding(0);
            this.ucSplitLabel_yearsRight.MaximumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsRight.MinimumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsRight.Name = "ucSplitLabel_yearsRight";
            this.ucSplitLabel_yearsRight.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_yearsRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucSplitLabel_yearsRight.Size = new System.Drawing.Size(99, 37);
            this.ucSplitLabel_yearsRight.TabIndex = 3;
            this.ucSplitLabel_yearsRight.Text = "2020";
            this.ucSplitLabel_yearsRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_text
            // 
            this.label_text.BackColor = System.Drawing.Color.Transparent;
            this.label_text.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text.Location = new System.Drawing.Point(202, 76);
            this.label_text.Margin = new System.Windows.Forms.Padding(0);
            this.label_text.Name = "label_text";
            this.label_text.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.label_text.Size = new System.Drawing.Size(483, 317);
            this.label_text.TabIndex = 8;
            this.label_text.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_text.Click += new System.EventHandler(this.label_text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(202, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ucProcessWave_co2
            // 
            this.ucProcessWave_co2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessWave_co2.ConerRadius = 0;
            this.ucProcessWave_co2.FillColor = System.Drawing.Color.Empty;
            this.ucProcessWave_co2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessWave_co2.ForeColor = System.Drawing.Color.Transparent;
            this.ucProcessWave_co2.IsRadius = false;
            this.ucProcessWave_co2.IsRectangle = true;
            this.ucProcessWave_co2.IsShowRect = false;
            this.ucProcessWave_co2.Location = new System.Drawing.Point(32, 212);
            this.ucProcessWave_co2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessWave_co2.MaxValue = 50;
            this.ucProcessWave_co2.Name = "ucProcessWave_co2";
            this.ucProcessWave_co2.RectColor = System.Drawing.Color.White;
            this.ucProcessWave_co2.RectWidth = 4;
            this.ucProcessWave_co2.Size = new System.Drawing.Size(45, 154);
            this.ucProcessWave_co2.TabIndex = 11;
            this.ucProcessWave_co2.TabStop = false;
            this.ucProcessWave_co2.Value = 0;
            this.ucProcessWave_co2.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessWave_co2.Click += new System.EventHandler(this.ucProcessWave_co2_Click);
            // 
            // label_co2
            // 
            this.label_co2.AutoSize = true;
            this.label_co2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_co2.ForeColor = System.Drawing.Color.Gray;
            this.label_co2.Location = new System.Drawing.Point(21, 371);
            this.label_co2.Name = "label_co2";
            this.label_co2.Size = new System.Drawing.Size(146, 20);
            this.label_co2.TabIndex = 12;
            this.label_co2.Text = "370ppm -1.52ppb/yr";
            this.label_co2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucProcessWave_ch4
            // 
            this.ucProcessWave_ch4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcessWave_ch4.ConerRadius = 0;
            this.ucProcessWave_ch4.FillColor = System.Drawing.Color.Empty;
            this.ucProcessWave_ch4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucProcessWave_ch4.ForeColor = System.Drawing.Color.Transparent;
            this.ucProcessWave_ch4.IsRadius = false;
            this.ucProcessWave_ch4.IsRectangle = true;
            this.ucProcessWave_ch4.IsShowRect = false;
            this.ucProcessWave_ch4.Location = new System.Drawing.Point(102, 212);
            this.ucProcessWave_ch4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucProcessWave_ch4.MaxValue = 160;
            this.ucProcessWave_ch4.Name = "ucProcessWave_ch4";
            this.ucProcessWave_ch4.RectColor = System.Drawing.Color.White;
            this.ucProcessWave_ch4.RectWidth = 4;
            this.ucProcessWave_ch4.Size = new System.Drawing.Size(45, 154);
            this.ucProcessWave_ch4.TabIndex = 11;
            this.ucProcessWave_ch4.TabStop = false;
            this.ucProcessWave_ch4.Value = 0;
            this.ucProcessWave_ch4.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcessWave_ch4.Click += new System.EventHandler(this.ucProcessWave_ch4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "二氧化碳濃度(左)\n甲烷增長率(右)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_main
            // 
            this.label_main.BackColor = System.Drawing.Color.White;
            this.label_main.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_main.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_main.Location = new System.Drawing.Point(12, 90);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(184, 45);
            this.label_main.TabIndex = 8;
            this.label_main.Text = "2000 年 1 月";
            this.label_main.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucRollText1
            // 
            this.ucRollText1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucRollText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucRollText1.Location = new System.Drawing.Point(100, 450);
            this.ucRollText1.MoveSleepTime = 80;
            this.ucRollText1.Name = "ucRollText1";
            this.ucRollText1.RollStyle = HZH_Controls.Controls.RollStyle.RightToLeft;
            this.ucRollText1.Size = new System.Drawing.Size(590, 30);
            this.ucRollText1.TabIndex = 14;
            this.ucRollText1.TabStop = false;
            this.ucRollText1.Text = "ucRollText1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.ucRollText1);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_co2);
            this.Controls.Add(this.ucProcessWave_ch4);
            this.Controls.Add(this.ucProcessWave_co2);
            this.Controls.Add(this.ucSplitLabel_yearsRight);
            this.Controls.Add(this.ucSplitLabel_yearsLeft);
            this.Controls.Add(this.ucThermometer_global);
            this.Controls.Add(this.ucTrackBar_year);
            this.Controls.Add(this.ucBtnImg1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RegionRadius = 20;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "大氣之歷史變動";
            this.Title = "大氣之歷史變動 - 2000年~2020年";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.ucBtnImg1, 0);
            this.Controls.SetChildIndex(this.ucTrackBar_year, 0);
            this.Controls.SetChildIndex(this.ucThermometer_global, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel_yearsLeft, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel_yearsRight, 0);
            this.Controls.SetChildIndex(this.ucProcessWave_co2, 0);
            this.Controls.SetChildIndex(this.ucProcessWave_ch4, 0);
            this.Controls.SetChildIndex(this.label_co2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label_text, 0);
            this.Controls.SetChildIndex(this.label_main, 0);
            this.Controls.SetChildIndex(this.ucRollText1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnImg ucBtnImg1;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_year;
        private HZH_Controls.Controls.UCThermometer ucThermometer_global;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsLeft;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsRight;
        private Label label_text;
        private HZH_Controls.Controls.UCProcessWave ucProcessWave_co2;
        private Label label_co2;
        private HZH_Controls.Controls.UCProcessWave ucProcessWave_ch4;
        private Label label1;
        private Label label_main;
        private PictureBox pictureBox1;
        private HZH_Controls.Controls.UCRollText ucRollText1;
    }
}