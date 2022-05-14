namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Student[] std = new Student[10];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            std[i] = new Student();
            std[i].ID = textBox1.Text;
            std[i].Name = textBox2.Text;
            std[i].Score = Convert.ToInt16(textBox3.Text);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sss = "";
            for (int a = 0; a < i; a++)
                sss += std[a].ShowMsg() + "\n";
            MessageBox.Show(sss);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}