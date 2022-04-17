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
        public FrmInfo(string info)
        {
            InitializeComponent();
            ucSplitLabel_info.Text = info;
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
