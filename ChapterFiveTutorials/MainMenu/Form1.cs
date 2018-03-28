using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoinToss.Form1 var = new CoinToss.Form1();
            var.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FriendFile.Form1 var = new FriendFile.Form1();
            var.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadEventApp.Form1 var = new LoadEventApp.Form1();
            var.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RunningTotal.Form1 var = new RunningTotal.Form1();
            var.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SouthAmerica.Form1 var = new SouthAmerica.Form1();
            var.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpeedConverter.Form1 var = new SpeedConverter.Form1();
            var.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FiveTwoEndingBalance.Form1 var = new FiveTwoEndingBalance.Form1();
            var.Show();
        }
    }
}
