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
            this.label_info = new System.Windows.Forms.Label();
            this.ucSplitLabel_info = new HZH_Controls.Controls.UCSplitLabel();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(23, 84);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(380, 201);
            this.label_info.TabIndex = 8;
            this.label_info.Text = "這裡還沒有參考資料。";
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 310);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.ucSplitLabel_info);
            this.IsShowCloseBtn = true;
            this.Name = "FrmInfo";
            this.RegionRadius = 30;
            this.Title = "參考資料";
            this.Controls.SetChildIndex(this.ucSplitLabel_info, 0);
            this.Controls.SetChildIndex(this.label_info, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label_info;
        private HZH_Controls.Controls.UCSplitLabel ucSplitLabel_info;
    }
}
