using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinToss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A counter will count the number of coin tosses
        int counter = 0;

        private void btnToss_Click(object sender, EventArgs e)
        {
            // A string variable will allow me to add items to the list box
            string output;

            // Variable will indicate which side is up
            int sideUp;

            // Create a Random object
            Random rand = new Random();

            // Get a random integer in the range of 0 through 1
            // 0 means tails up, 1 means heads up
            sideUp = rand.Next(2);

            // Display the side that is up
            if (sideUp == 0)
            {
                // Display tails up
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;

                // Increment the counter
                counter = counter + 1;

                // Save string to add to lis box
                 output = "Coin toss number : " + counter.ToString() + "  was Tails.";

                // Populate list box with output variable
                outPutListBox.Items.Add(output);

                // Display current toss
                displayText.Text = output;
            }
            else
            {
                // Display heads up
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;

                // Increment the counter
                counter = counter + 1;

                // Save string to add to lis box
                output = "Coin toss number : " + counter.ToString() + "  was Heads.";

                // Populate list box with output variable
                outPutListBox.Items.Add(output);

                // Display current toss
                displayText.Text = output;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            displayText.Text = " ";
            outPutListBox.Items.Clear();
        }
    }
}
