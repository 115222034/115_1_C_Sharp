namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true; pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true; pictureBox1.Visible = false;
        }
    }
}
