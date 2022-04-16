using Test;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucBtnImg1_BtnClick(object sender, EventArgs e)
        {
            new FrmWithTitleTest().ShowDialog();
        }

        private void ucTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            float[] HadCRUT5 = { 1.04f, 0.89f, 0.93f, 0.98f, 1.03f, 1.18f, 1.29f, 1.20f, 1.12f, 1.12f, 1.28f };
            if (ucTrackBar1.Value >= 2010 && ucTrackBar1.Value <= 2020)
            {
                ucThermometer1.Visible = true;
                ucThermometer1.Value = (decimal)HadCRUT5[(int)(ucTrackBar1.Value - 2010)];
            }
            else
            {
                ucThermometer1.Visible = false;
            }
        }

        private void ucSplitLabel_yearsLeft_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int mid = (int)(ucTrackBar1.Value - 2010);
            Random r = new Random();
            int i = r.Next(mid - 10, mid + 10);
            //ucSplitLabel1.Text = i.ToString();
            //ucWaveChart1.AddSource(i.ToString(), i);
        }
    }
}