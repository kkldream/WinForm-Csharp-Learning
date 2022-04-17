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
            this.ucSplitLabel_text = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel_yearsLeft = new HZH_Controls.Controls.UCSplitLabel();
            this.ucSplitLabel_yearsRight = new HZH_Controls.Controls.UCSplitLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.ucBtnImg1.FillColor = System.Drawing.Color.Silver;
            this.ucBtnImg1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImg1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucBtnImg1.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImg1.Image")));
            this.ucBtnImg1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucBtnImg1.ImageFontIcons = null;
            this.ucBtnImg1.IsRadius = true;
            this.ucBtnImg1.IsShowRect = false;
            this.ucBtnImg1.IsShowTips = false;
            this.ucBtnImg1.Location = new System.Drawing.Point(726, 73);
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
            this.ucTrackBar1.Location = new System.Drawing.Point(34, 353);
            this.ucTrackBar1.MaxValue = 2022F;
            this.ucTrackBar1.MinValue = 2000F;
            this.ucTrackBar1.Name = "ucTrackBar1";
            this.ucTrackBar1.Size = new System.Drawing.Size(735, 48);
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
            this.ucThermometer1.Location = new System.Drawing.Point(726, 152);
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
            this.ucThermometer1.Size = new System.Drawing.Size(73, 195);
            this.ucThermometer1.SplitCount = 5;
            this.ucThermometer1.TabIndex = 2;
            this.ucThermometer1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucThermometer1.Visible = false;
            // 
            // ucSplitLabel_text
            // 
            this.ucSplitLabel_text.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ucSplitLabel_text.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_text.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_text.Location = new System.Drawing.Point(226, 218);
            this.ucSplitLabel_text.MaximumSize = new System.Drawing.Size(0, 29);
            this.ucSplitLabel_text.MinimumSize = new System.Drawing.Size(150, 29);
            this.ucSplitLabel_text.Name = "ucSplitLabel_text";
            this.ucSplitLabel_text.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_text.Size = new System.Drawing.Size(150, 29);
            this.ucSplitLabel_text.TabIndex = 3;
            this.ucSplitLabel_text.Text = "text";
            // 
            // ucSplitLabel_yearsLeft
            // 
            this.ucSplitLabel_yearsLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ucSplitLabel_yearsLeft.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_yearsLeft.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_yearsLeft.Location = new System.Drawing.Point(12, 404);
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
            this.ucSplitLabel_yearsLeft.Click += new System.EventHandler(this.ucSplitLabel_yearsLeft_Click);
            // 
            // ucSplitLabel_yearsRight
            // 
            this.ucSplitLabel_yearsRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.ucSplitLabel_yearsRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucSplitLabel_yearsRight.Click += new System.EventHandler(this.ucSplitLabel_yearsLeft_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucSplitLabel_yearsRight);
            this.Controls.Add(this.ucSplitLabel_yearsLeft);
            this.Controls.Add(this.ucSplitLabel_text);
            this.Controls.Add(this.ucThermometer1);
            this.Controls.Add(this.ucTrackBar1);
            this.Controls.Add(this.ucBtnImg1);
            this.IsShowCloseBtn = true;
            this.Name = "Form1";
            this.Text = "大氣之歷史變動";
            this.Title = "大氣之歷史變動";
            this.Controls.SetChildIndex(this.ucBtnImg1, 0);
            this.Controls.SetChildIndex(this.ucTrackBar1, 0);
            this.Controls.SetChildIndex(this.ucThermometer1, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel_text, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel_yearsLeft, 0);
            this.Controls.SetChildIndex(this.ucSplitLabel_yearsRight, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCBtnImg ucBtnImg1;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar1;
        private HZH_Controls.Controls.UCThermometer ucThermometer1;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_text;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsLeft;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_yearsRight;
        private System.Windows.Forms.Timer timer1;
    }
}