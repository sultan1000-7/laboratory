using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cMaterial.Items.AddRange(new string[] { "Алюминий", "Дерево", "Пластик", "Ткань"});
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            resultLabel.ForeColor = Color.Red;
            if (!cMaterial.Items.Contains(cMaterial.Text))
            {
                resultLabel.Text = "Выберите материал из списка";
            }
            else if (!horizontalBlinds.Checked && !verticalBlinds.Checked && !rollerBlinds.Checked && !mosaicBlinds.Checked)
            {
                resultLabel.Text = "Выберите тип жалюзей";
            }
            else
            {
                try
                {
                    int height = int.Parse(tHeight.Text),
                        width = int.Parse(tWidth.Text);
                    resultLabel.ForeColor = Color.Black;
                    resultLabel.Text = $"{height * width * Price.Money * Price.Multiplier} руб.";
                }
                catch (Exception)
                {
                    resultLabel.Text = "Введены неверные значения";
                }
            }
            
            
        }

        static class Price
        {
            public static int Money { get; set; }
            public static double Multiplier { get; set; }
        }

        private void horizontalBlinds_CheckedChanged(object sender, EventArgs e)
        {
            Price.Multiplier = 1.05;
        }

        private void verticalBlinds_CheckedChanged(object sender, EventArgs e)
        {
            Price.Multiplier = 1.1;
        }

        private void rollerBlinds_CheckedChanged(object sender, EventArgs e)
        {
            Price.Multiplier = 1.2;
        }

        private void mosaicBlinds_CheckedChanged(object sender, EventArgs e)
        {
            Price.Multiplier = 1.35;
        }

        private void cMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cMaterial.Text == "Алюминий") { Price.Money = 5; }
            else if(cMaterial.Text == "Дерево") { Price.Money = 3; }
            else if(cMaterial.Text == "Пластик") { Price.Money = 2; }
            else if(cMaterial.Text == "Ткань") { Price.Money = 1; }
        }
    }
}
