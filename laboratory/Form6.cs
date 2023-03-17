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
    public partial class Form6 : Form
    {
        static List<Date> dates = new List<Date>();
        public Form6()
        {
            InitializeComponent();
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            Date date = new Date(txtStateNumber.Text, txtModel.Text, txtColor.Text, txtFullName.Text);
            dates.Add(date);
            ClearDate();
            CheckForAvailability();
        }

        void CheckForAvailability()
        {
            foreach (var item in dates)
            {
                if (!cmbNumbers.Items.Contains(item.Number))
                {
                    cmbNumbers.Items.Add(item.Number);
                }
            }
        }

        void ClearDate()
        {
            txtColor.Text = null;
            txtFullName.Text = null;
            txtStateNumber.Text = null;
            txtModel.Text = null;
            cmbNumbers.Text = null;
        }

        private void cmbNumbers_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in dates)
            {
                if (item.Number == cmbNumbers.Text)
                {
                    txtStateNumber.Text = item.Number;
                    txtModel.Text = item.Model;
                    txtColor.Text = item.Color;
                    txtFullName.Text = item.FullName;
                    break;
                }
                else if (cmbNumbers.Text == null) { ClearDate(); }
                else { ClearDate(); }
            }
        }

        private void bClear_Click(object sender, EventArgs e) { ClearDate(); }
    }

    struct Date
    {
        public Date(string number, string model, string color, string fullName)
        {
            Number = number;
            Model = model;
            Color = color;
            FullName = fullName;
        }
        public string Number { get; }
        public string Model { get; }
        public string Color { get; }
        public string FullName { get; }
    }
}
