using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FriendFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteName_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable
                StreamWriter outputFile;



                // Open the Friend.Txt file for appending,
                // and get a StreamWriter object
                outputFile = File.AppendText("Friend.txt");

                // Write the friend's name to the file
                outputFile.WriteLine(textBox1.Text);

                // Close the file
                outputFile.Close();

                // Let the user know the name was written
                MessageBox.Show("The name was written.");

                // Clear the TextBox control
                textBox1.Text = " ";

                // Give the focus to the TextBox control
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
