namespace WinFormsApp1
{
    partial class FrmInfo
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ucSplitLabel_info = new HZH_Controls.Controls.UCSplitLabel();
            this.SuspendLayout();
            // 
            // ucSplitLabel_info
            // 
            this.ucSplitLabel_info.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ucSplitLabel_info.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ucSplitLabel_info.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucSplitLabel_info.Location = new System.Drawing.Point(62, 106);
            this.ucSplitLabel_info.MaximumSize = new System.Drawing.Size(0, 25);
            this.ucSplitLabel_info.MinimumSize = new System.Drawing.Size(150, 25);
            this.ucSplitLabel_info.Name = "ucSplitLabel_info";
            this.ucSplitLabel_info.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucSplitLabel_info.Size = new System.Drawing.Size(299, 25);
            this.ucSplitLabel_info.TabIndex = 7;
            this.ucSplitLabel_info.Text = "ucSplitLabel_info";
            this.ucSplitLabel_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 310);
            this.Controls.Add(this.ucSplitLabel_info);
            this.IsShowCloseBtn = true;
            this.Name = "FrmInfo";
            this.RegionRadius = 30;
            this.Title = "參考資料";
            this.Load += new System.EventHandler(this.FrmInfo_Load);
            this.Controls.SetChildIndex(this.ucSplitLabel_info, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_info;
    }
}
