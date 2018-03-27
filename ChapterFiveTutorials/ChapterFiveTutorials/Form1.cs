using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterFiveTutorials
{
    public partial class detailListBox : Form
    {
        public detailListBox()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Constant for the monthly interest
            const double INTEREST_RATE = 0.005;

            // Local Variables
            double balance;        // The account balance
            int months;             // The number of months
            int count = 1;          // Loop counter, initialized with 1

            try
            {
                // Get the starting balance
                if (double.TryParse(textBox1.Text, out balance))
                {
                    // Get the number of months
                    if (int.TryParse(textBox2.Text, out months))
                    {
                        // The following loop calculates the ending balance
                        while (count <= months)
                        {
                            // Add this months interest to the balance
                            balance = balance + (INTEREST_RATE * balance);

                            // Display this month's interest to the balance
                            listBox1.Items.Add
                            ("The ending balance " + "for month " + count + " is " +
                            balance.ToString("c"));

                            // Add one to the loop counter
                            count = count + 1;
                        }
                        // Display the ending balance
                        outPutLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        // Invalid number of months was entered.
                        MessageBox.Show("Invalid value for months.");
                    }
                }
                else
                {
                    // Invalid starting balance was entered.
                    MessageBox.Show("Invalid value for string balance.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            listBox1.Items.Clear();
            outPutLabel.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
