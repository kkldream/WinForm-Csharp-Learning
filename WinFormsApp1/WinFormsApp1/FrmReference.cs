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
    public partial class FrmReference : HZH_Controls.Forms.FrmWithTitle
    {
        public FrmReference()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink(Resource.Resource_1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink(Resource.Resource_2);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink(Resource.Resource_3);
        }
        private void VisitLink(string link)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start(Resource.browserPath, link);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }
        }
    }
}
