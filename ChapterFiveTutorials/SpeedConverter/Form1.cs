using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Constants
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            // Variables
            int kph;        //Kilometers per hour
            double mph;     //Miles per hour

            try
            {
                // Display the table for speeds
                for (kph = START_SPEED; kph <= END_SPEED; kph += INTERVAL)
                {
                    // Calculate miles per hour
                    mph = kph * CONVERSION_FACTOR;

                    // Display the conversion
                    outputListBox.Items.Add(kph + " KPH is the same as " +
                        mph + " MPH");
                }
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
