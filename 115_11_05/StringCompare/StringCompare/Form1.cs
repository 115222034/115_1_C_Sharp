namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (txtString1.Text == txtString2.Text) { MessageBox.Show("兩個字串相同"); }
            else { MessageBox.Show("兩個字串不同"); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
