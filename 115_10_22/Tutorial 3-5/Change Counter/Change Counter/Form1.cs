using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalLabel.Text = (double.Parse(totalLabel.Text)+5).ToString();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalLabel.Text = (double.Parse(totalLabel.Text) + 10).ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalLabel.Text = (double.Parse(totalLabel.Text) + 25).ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalLabel.Text = (double.Parse(totalLabel.Text) + 50).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
