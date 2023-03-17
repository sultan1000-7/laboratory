namespace laboratory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CalculateMoney.MoneyFromSize = 5;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                CalculateMoney.MoneyFromSize = 10;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                CalculateMoney.MoneyFromSize = 15;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                CalculateMoney.MoneyFromSize = 20;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                CalculateMoney.MoneyFromType = 15;
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                CalculateMoney.MoneyFromType = 35;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                CalculateMoney.MoneyFromType = 50;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateMoney.Page = ((TextBox)sender).Text;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(CalculateMoney.MoneyFromSize == 0)
            {
                MessageBox.Show("Выберите размер фото");
            }
            else if(CalculateMoney.MoneyFromType == 0)
            {
                MessageBox.Show("Выберите тип фото");
            }
            else if(textBox1.Text == "0" || textBox1.Text == "")
            {
                MessageBox.Show("Нужно ввести 1 и более страниц");
            }
            else
            {
                try
                {
                    MessageBox.Show($"К оплате " +
                        $"{(CalculateMoney.MoneyFromSize + CalculateMoney.MoneyFromType)
                        * int.Parse(CalculateMoney.Page)} рублей");
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите число");
                }
            }
        }
    }
    static class CalculateMoney
    {
        public static int MoneyFromSize { get; set; }
        public static int MoneyFromType { get; set; }
        public static string Page { get; set; }
    }
}