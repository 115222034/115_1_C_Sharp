namespace Tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "芬蘭";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "法國";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "德國";
        }
    }
}
