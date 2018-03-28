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
namespace LoadEventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a country name
                string countryName;

                // Declare a Stream Reader variable
                StreamReader inputFile;

                // Open the file and get a StreamReader object
                inputFile = File.OpenText("Countries.txt");

                // Read the files contents
                while (!inputFile.EndOfStream)
                {
                    // Get country name
                    countryName = inputFile.ReadLine();

                    // Add the country name to the list box
                    countriesListBox.Items.Add(countryName);
                }
                // close the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
