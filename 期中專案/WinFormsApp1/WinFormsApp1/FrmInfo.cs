using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmInfo : HZH_Controls.Forms.FrmWithTitle
    {
        public FrmInfo(string? info)
        {
            InitializeComponent();
            label_info.Text = info;
        }
        public FrmInfo(string? title, string? info, int addHight=0)
        {
            InitializeComponent();
            this.Title = title;
            this.ClientSize = new System.Drawing.Size(427, 310 + addHight);
            this.label_info.Size = new System.Drawing.Size(380, 201 + addHight);
            label_info.Text = info;
        }
    }
}
