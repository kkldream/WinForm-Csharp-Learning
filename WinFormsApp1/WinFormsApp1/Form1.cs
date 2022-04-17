using System.Reflection;
using System.Resources;
using System.Globalization;
namespace WinFormsApp1
{
    public partial class Form1 : HZH_Controls.Forms.FrmWithTitle
    {
        string dirPath = Resource.dirPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void ucBtnImg1_BtnClick(object sender, EventArgs e)
        {
            new FrmReference().ShowDialog(this);
            //new FrmInfo(Resource.info_nothing).ShowDialog(this);
        }
        double[] ch4_growth_rate = { -1.52, -0.73, 3.27, 4.80, -4.89, 0.38, 1.94, 7.79, 6.53, 4.70, 5.19, 4.83, 5.01, 5.70, 12.77, 10.02, 7.09, 6.85, 8.67, 9.89, 15.27 };
        private void ucTrackBar_year_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)ucTrackBar_year.Value;

            label_main.Text = $"{value} 年 {(int)(ucTrackBar_year.Value % 1 * 12 + 1)} 月";

            double ch4_value;
            if (value == 2020) 
                ch4_value = ch4_growth_rate[20];
            else
                ch4_value = ch4_growth_rate[value - 2000] + (ch4_growth_rate[value - 2000 + 1] - ch4_growth_rate[value - 2000]) * (double)(ucTrackBar_year.Value % 1);
            ucProcessWave_ch4.Value = (int)(ch4_value * 10);

            ucThermometer_global.Value = (decimal)((ucTrackBar_year.Value - 2000) / 20 * 0.4 + 0.5);
            ucProcessWave_co2.Value = (int)((ucTrackBar_year.Value - 2000) * 2);

            label_co2.Text = $"{370 + (int)((ucTrackBar_year.Value - 2000) * 2)}ppm  {(float)((int)(ch4_value * 100) / 100f)}ppb/yr";

            switch (value)
            {
                case 2000:
                case 2001:
                    setImage("1920px-Top_of_Atmosphere.jpg");
                    label_text.Text = Resource.text_2000;
                    break;
                case 2002:
                case 2003:
                    setImage();
                    label_text.Text = Resource.text_2002;
                    break;
                case 2004:
                case 2005:
                    setImage("Snipaste_2022-04-17_21-53-15.png");
                    label_text.Text = "";
                    break;
                case 2006:
                    setImage();
                    label_text.Text = Resource.text_2006;
                    break;
                case 2007:
                case 2008:
                    setImage();
                    label_text.Text = Resource.text_2007;
                    break;
                case 2009:
                    setImage();
                    label_text.Text = Resource.text_2009;
                    break;
                case 2010:
                case 2011:
                case 2012:
                    setImage("Snipaste_2022-04-17_22-05-50.png");
                    label_text.Text = "";
                    break;
                case 2013:
                case 2014:
                    setImage();
                    label_text.Text = Resource.text_2013;
                    break;
                case 2015:
                case 2016:
                case 2017:
                    setImage("Snipaste_2022-04-17_22-10-27.png");
                    label_text.Text = "";
                    break;
                case 2018:
                    setImage();
                    label_text.Text = Resource.text_2018;
                    break;
                case 2019:
                case 2020:
                    setImage("Snipaste_2022-04-17_22-11-18.png");
                    label_text.Text = "";
                    break;
                default:
                    setImage();
                    label_text.Text = "";
                    break;

            }
        }

        private void ucProcessWave_co2_Click(object sender, EventArgs e)
        {
            //new FrmInfo("大氣層中的二氧化碳濃度(ppm)", Resource.info_co2, 180).ShowDialog(this);
            string imgName = "climate8-5-1.png";
            new FrmInfoImg("大氣層中的二氧化碳濃度(ppm)", Resource.info_co2, imgName, 395).ShowDialog(this);
        }
        private void ucProcessWave_ch4_Click(object sender, EventArgs e)
        {
            //new FrmInfo("大氣層中的甲烷增長率(ppb/yr)", Resource.info_ch4, 180).ShowDialog(this);
            string imgName = "climate8-5-4.png";
            new FrmInfoImg("大氣層中的甲烷增長率(ppb/yr)", Resource.info_ch4, imgName, 330).ShowDialog(this);
        }

        private void ucThermometer_global_Click(object sender, EventArgs e)
        {
            string imgName = "Global_Temperature_Anomaly.svg.png";
            new FrmInfoImg("全球溫度異常", Resource.info_globalTemp, imgName, 140).ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setImage("1920px-Top_of_Atmosphere.jpg");
            label_text.Parent = pictureBox1;
            label_text.Location = new Point(0, pictureBox1.Height - label_text.Height);
            label_text.Text = Resource.text_2000;
            ucRollText1.Text = Resource.text_roll;
        }

        private void setImage(string imgName)
        {
            pictureBox1.Image = new Bitmap(dirPath + imgName);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void setImage()
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox1.Image = null;
        }

        private void label_text_Click(object sender, EventArgs e)
        {

        }
    }
}