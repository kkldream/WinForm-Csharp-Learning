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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucBtnImg1 = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBar1 = new HZH_Controls.Controls.UCTrackBar();
            this.ucThermometer1 = new HZH_Controls.Controls.UCThermometer();
            this.ucSplitLabel1 = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel_yearsLeft = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel_yearsRight = new HZH_Controls.Controls.UCSplitLabel();
            this.ucWaveChart1 = new HZH_Controls.Controls.UCWaveChart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ucBtnImg1
            // 
            this.ucBtnImg1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImg1.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImg1.BtnFont = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucBtnImg1.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg1.BtnText = "";
            this.ucBtnImg1.ConerRadius = 60;
            this.ucBtnImg1.EnabledMouseEffect = true;
            this.ucBtnImg1.FillColor = System.Drawing.Color.Silver;
            this.ucBtnImg1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImg1.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg1.Image")));
            this.ucBtnImg1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg1.ImageFontIcons = null;
            this.ucBtnImg1.IsRadius = true;
            this.ucBtnImg1.IsShowRect = false;
            this.ucBtnImg1.IsShowTips = false;
            this.ucBtnImg1.Location = new System.Drawing.Point(724, 9);
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
            // ucTrackBar1
            // 
            this.ucTrackBar1.DcimalDigits = 0;
            this.ucTrackBar1.IsShowTips = true;
            this.ucTrackBar1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar1.LineWidth = 20F;
            this.ucTrackBar1.Location = new System.Drawing.Point(12, 353);
            this.ucTrackBar1.MaxValue = 2022F;
            this.ucTrackBar1.MinValue = 2000F;
            this.ucTrackBar1.Name = "ucTrackBar1";
            this.ucTrackBar1.Size = new System.Drawing.Size(776, 48);
            this.ucTrackBar1.TabIndex = 1;
            this.ucTrackBar1.Text = "ucTrackBar1";
            this.ucTrackBar1.TipsFormat = null;
            this.ucTrackBar1.Value = 2000F;
            this.ucTrackBar1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTrackBar1.ValueChanged += new System.EventHandler(this.ucTrackBar1_ValueChanged);
            // 
            // ucThermometer1
            // 
            this.ucThermometer1.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ucThermometer1.LeftTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.C;
            this.ucThermometer1.Location = new System.Drawing.Point(689, 106);
            this.ucThermometer1.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ucThermometer1.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucThermometer1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer1.Name = "ucThermometer1";
            this.ucThermometer1.RightTemperatureUnit = HZH_Controls.Controls.TemperatureUnit.None;
            this.ucThermometer1.Size = new System.Drawing.Size(92, 241);
            this.ucThermometer1.SplitCount = 5;
            this.ucThermometer1.TabIndex = 2;
            this.ucThermometer1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer1.Visible = false;
            // 
            // ucSplitLabel1
            // 
            this.ucSplitLabel1.AutoSize = true;
            this.ucSplitLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel1.Location = new System.Drawing.Point(12, 13);
            this.ucSplitLabel1.MaximumSize = new System.Drawing.Size(0, 55);
            this.ucSplitLabel1.MinimumSize = new System.Drawing.Size(150, 55);
            this.ucSplitLabel1.Name = "ucSplitLabel1";
            this.ucSplitLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel1.Size = new System.Drawing.Size(202, 55);
            this.ucSplitLabel1.TabIndex = 3;
            this.ucSplitLabel1.Text = "事件名稱";
            // 
            // ucSplitLabel_yearsLeft
            // 
            this.ucSplitLabel_yearsLeft.AutoSize = true;
            this.ucSplitLabel_yearsLeft.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_yearsLeft.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_yearsLeft.Location = new System.Drawing.Point(-11, 404);
            this.ucSplitLabel_yearsLeft.Margin = new System.Windows.Forms.Padding(0);
            this.ucSplitLabel_yearsLeft.MaximumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsLeft.MinimumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsLeft.Name = "ucSplitLabel_yearsLeft";
            this.ucSplitLabel_yearsLeft.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_yearsLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucSplitLabel_yearsLeft.Size = new System.Drawing.Size(99, 37);
            this.ucSplitLabel_yearsLeft.TabIndex = 3;
            this.ucSplitLabel_yearsLeft.Text = "2000";
            this.ucSplitLabel_yearsLeft.Click += new System.EventHandler(this.ucSplitLabel_yearsLeft_Click);
            // 
            // ucSplitLabel_yearsRight
            // 
            this.ucSplitLabel_yearsRight.AutoSize = true;
            this.ucSplitLabel_yearsRight.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_yearsRight.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_yearsRight.Location = new System.Drawing.Point(689, 404);
            this.ucSplitLabel_yearsRight.Margin = new System.Windows.Forms.Padding(0);
            this.ucSplitLabel_yearsRight.MaximumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsRight.MinimumSize = new System.Drawing.Size(0, 37);
            this.ucSplitLabel_yearsRight.Name = "ucSplitLabel_yearsRight";
            this.ucSplitLabel_yearsRight.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_yearsRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucSplitLabel_yearsRight.Size = new System.Drawing.Size(99, 37);
            this.ucSplitLabel_yearsRight.TabIndex = 3;
            this.ucSplitLabel_yearsRight.Text = "2022";
            this.ucSplitLabel_yearsRight.Click += new System.EventHandler(this.ucSplitLabel_yearsLeft_Click);
            // 
            // ucWaveChart1
            // 
            this.ucWaveChart1.ConerRadius = 10;
            this.ucWaveChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucWaveChart1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.IsRadius = true;
            this.ucWaveChart1.IsShowRect = true;
            this.ucWaveChart1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.LineTension = 0.5F;
            this.ucWaveChart1.Location = new System.Drawing.Point(234, 118);
            this.ucWaveChart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucWaveChart1.Name = "ucWaveChart1";
            this.ucWaveChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucWaveChart1.RectWidth = 1;
            this.ucWaveChart1.Size = new System.Drawing.Size(300, 200);
            this.ucWaveChart1.SleepTime = 1000;
            this.ucWaveChart1.TabIndex = 5;
            this.ucWaveChart1.WaveWidth = 50;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucWaveChart1);
            this.Controls.Add(this.ucSplitLabel_yearsRight);
            this.Controls.Add(this.ucSplitLabel_yearsLeft);
            this.Controls.Add(this.ucSplitLabel1);
            this.Controls.Add(this.ucThermometer1);
            this.Controls.Add(this.ucTrackBar1);
            this.Controls.Add(this.ucBtnImg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCBtnImg ucBtnImg1;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar1;
        private HZH_Controls.Controls.UCThermometer ucThermometer1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsLeft;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsRight;
        private HZH_Controls.Controls.UCWaveChart ucWaveChart1;
        private System.Windows.Forms.Timer timer1;
    }
}