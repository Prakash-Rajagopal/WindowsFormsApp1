using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Electronics");
            listBox1.Items.Add("Groceries");
            listBox1.Items.Add("Garments");
            listBox1.Items.Add("Toys");
            listBox1.Items.Add("Furnitures");
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = " ";
            foreach(var i in listBox1.SelectedItems)
            {
                s += i;
            }
            MessageBox.Show("Added Items " + s, "ViewCart", MessageBoxButtons.OKCancel);
        }
    }
}
