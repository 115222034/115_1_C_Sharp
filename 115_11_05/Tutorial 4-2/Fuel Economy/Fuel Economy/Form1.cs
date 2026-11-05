using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;

            if (!double.TryParse(milesTextBox.Text, out miles))
            {
                MessageBox.Show("請輸入有效的行駛公里數。");
                milesTextBox.Focus();
                return;
            }

            if (!double.TryParse(gallonsTextBox.Text, out gallons) || gallons <= 0)
            {
                MessageBox.Show("請輸入有效汽油公升數。");
                gallonsTextBox.Focus();
                return;
            }

            mpgLabel.Text = (miles / gallons).ToString("n2") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void mpgLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
