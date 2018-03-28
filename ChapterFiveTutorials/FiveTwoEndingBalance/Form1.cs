using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveTwoEndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try { 
            // Constant for the monthly interest rate
            const double INTEREST_RATE = 0.005;

            // Local variables
            double balance;         // The account balance
            int month;              // The number of months
            int count = 1;          // Loop counter, initialized with 1

            
                // Get the starting balance
                if (double.TryParse(balanceTextBox.Text, out balance))
                {
                    // Get the number of months
                    if (int.TryParse(monthsTextBox.Text, out month))
                    {
                        // The following loop calculates the ending balance
                        while (count <= month)
                        {
                            // Add this months interest to the balance
                            balance = balance + (INTEREST_RATE * balance);

                            //Display this months ending balance
                            detailListBox.Items.Add("The ending balance " +
                                "for month " + count + " is " + balance.ToString("c"));

                            // Add one to the loop counter
                            count = count + 1;
                        }

                        // Display the ending balance
                        outputLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        // Invalid number of months was entered
                        MessageBox.Show("Invalid value for months");
                    }
                }
                else
                {
                    // Invalid starting balance was entered
                    MessageBox.Show("Invalid value for starting balance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text
            outputLabel.Text = " ";
            detailListBox.Items.Clear();
            balanceTextBox.Text = " ";
            monthsTextBox.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
