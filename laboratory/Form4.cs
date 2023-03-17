using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bShowResult_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (bigMac.Checked == true) { price += 250; }
            if (sauce.Checked == true) { price += 50; }
            if (beacon.Checked == true) { price += 100; }
            if (potato.Checked == true) { price += 80; }
            if (price == 0)
            {
                
                textBox1.Text = "А чё есть не будем?";
            }
            else
            {
                textBox1.Text = $"{price} руб.";
            }
        }
    }
}
