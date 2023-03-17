using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace laboratory
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadLists();
        }
        private void ListDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void startList_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.Text);
            if (startList.Items.Contains(data)) { return; }
            startList.Items.Add(data);
            favouriteList.Items.Remove(data);
            notFavouriteList.Items.Remove(data);
        }

        private void favouriteList_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.Text);
            if (favouriteList.Items.Contains(data)) { return; }
            favouriteList.Items.Add(data);
            startList.Items.Remove(data);
            notFavouriteList.Items.Remove(data);
        }
        private void notFavouriteList_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.Text);
            if (notFavouriteList.Items.Contains(data)) { return; }
            notFavouriteList.Items.Add(data);
            favouriteList.Items.Remove(data);
            startList.Items.Remove(data);
        }

        private void ListMouseDown(object sender, MouseEventArgs e)
        {
            if (notFavouriteList.SelectedItem is not null)
            {
                DoDragDrop(notFavouriteList.SelectedItem.ToString(), DragDropEffects.Move);
            }
            else if (favouriteList.SelectedItem is not null)
            {
                DoDragDrop(favouriteList.SelectedItem.ToString(), DragDropEffects.Move);
            }
            else if (startList.SelectedItem is not null)
            {
                DoDragDrop(startList.SelectedItem.ToString(), DragDropEffects.Move);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = startList.SelectedItem;
            if (item is not null)
            {
                favouriteList.Items.Add(item);
                startList.Items.Remove(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = favouriteList.SelectedItem;
            if (item is not null)
            {
                startList.Items.Add(item);
                favouriteList.Items.Remove(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = startList.SelectedItem;
            if (item is not null)
            {
                notFavouriteList.Items.Add(item);
                startList.Items.Remove(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var item = notFavouriteList.SelectedItem;
            if (item is not null)
            {
                startList.Items.Add(item);
                notFavouriteList.Items.Remove(item);
            }
        }

        private void FormMouseClick(object sender, MouseEventArgs e)
        {
            startList.SelectedItem = null;
            favouriteList.SelectedItem = null;
            notFavouriteList.SelectedItem = null;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("C:/sultan/lists/start.txt"))
            {
                foreach(var item in startList.Items)
                {
                    sw.WriteLine(item);
                }
            }
            using (StreamWriter sw = new StreamWriter("C:/sultan/lists/favourite.txt"))
            {
                foreach (var item in favouriteList.Items)
                {
                    sw.WriteLine(item);
                }
            }
            using (StreamWriter sw = new StreamWriter("C:/sultan/lists/notFavourite.txt"))
            {
                foreach (var item in notFavouriteList.Items)
                {
                    sw.WriteLine(item);
                }
            }
            Application.Exit();
        }
        void LoadLists()
        {
            using (StreamReader sr = new StreamReader("C:/sultan/lists/start.txt"))
            {
                string? line;
                
                while((line = sr.ReadLine()) != null)
                {
                    startList.Items.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader("C:/sultan/lists/favourite.txt"))
            {
                string? line;
                while((line = sr.ReadLine()) != null)
                {
                    favouriteList.Items.Add(line);
                }
            }
            using (StreamReader sr = new StreamReader("C:/sultan/lists/notFavourite.txt"))
            {
                string? line;
                while((line = sr.ReadLine()) != null)
                {
                    notFavouriteList.Items.Add(line);
                }
            }
        }
    }
}
