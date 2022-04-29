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
    public partial class FrmInfoImg : HZH_Controls.Forms.FrmWithTitle
    {
        string dirPath = Resource.dirPath;
        public FrmInfoImg()
        {
            InitializeComponent();
        }

        public FrmInfoImg(string? info)
        {
            InitializeComponent();
            label1.Text = info;
        }
        public FrmInfoImg(string? title, string? info, string? imgName, int addHight = 0)
        {
            InitializeComponent();
            Title = title;
            ClientSize = new System.Drawing.Size(427, 310 + addHight);
            label1.Size = new System.Drawing.Size(380, 201 + addHight);
            label1.Text = info;
            pictureBox1.Image = new Bitmap(dirPath + imgName);

        }
    }
}
