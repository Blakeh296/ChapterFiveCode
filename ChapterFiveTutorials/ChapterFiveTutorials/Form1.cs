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
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            outPutLabel.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
