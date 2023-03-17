using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laboratory.Properties;

namespace laboratory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.IsAccessible = false;
            comboBox1.Items.AddRange(new string[] { "audi", "bmw", "mercedes", "maclaren" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money =Price.Money;
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                MessageBox.Show("Выберите Модель");
            }
            
            if(checkBox1.Checked) { money *= 1.2; }
            if(checkBox2.Checked) { money *= 1.1; }
            if(checkBox3.Checked) { money *= 1.05; }
            if(checkBox4.Checked) { money *= 1.15; }
            if(comboBox1.Items.Contains(comboBox1.Text))
            {
                showTotalPrice.Text = $"{Math.Ceiling(money)} руб.";
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "audi") 
            {
                carPhoto.BackgroundImage = Resources.audi_s4_audi_mashina_krasnyy;
                carPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                showBasePrice.Text = $"{Price.Money = 900000} руб."; 
            }
            else if(comboBox1.Text == "bmw") 
            {
                carPhoto.BackgroundImage = Resources.foto_m3_f80_111;
                carPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                showBasePrice.Text = $"{Price.Money = 1500000} руб.";
            }
            else if(comboBox1.Text == "mercedes") 
            {
                carPhoto.BackgroundImage = Resources._1643714033_15_hdpic_club_p_mersedes_210_kuzov_39;
                carPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                showBasePrice.Text = $"{Price.Money = 570000} руб."; 
            }
            else if(comboBox1.Text == "maclaren") 
            {
                carPhoto.BackgroundImage = Resources.mclaren;
                carPhoto.BackgroundImageLayout = ImageLayout.Stretch;
                showBasePrice.Text = $"{Price.Money = 7000000} руб."; 
            }
        }

        private void showBasePrice_TextChanged(object sender, EventArgs e)
        {
            
        }
        static class Price
        {
            public static double Money { get; set; }
        }
    }
}
