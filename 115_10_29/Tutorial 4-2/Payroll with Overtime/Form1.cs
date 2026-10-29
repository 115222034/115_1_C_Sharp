using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a;

                a = decimal.Parse(hourlyPayRateTextBox.Text) * decimal.Parse(hoursWorkedTextBox.Text);
                if (decimal.Parse(hoursWorkedTextBox.Text) > 40)
                {
                    a = a + (decimal.Parse(hoursWorkedTextBox.Text) - 40) * decimal.Parse(hourlyPayRateTextBox.Text) * 0.5m;
                }
                grossPayLabel.Text = a.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("格式有誤，只能輸入數字，並且不可為空白。", ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void grossPayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
