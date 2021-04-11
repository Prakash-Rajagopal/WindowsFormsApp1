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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Regular);
            }

            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Bold | FontStyle.Italic);
                 
            }
            else
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox3.Checked == true) && (checkBox2.Checked == true) &&
                (checkBox3.Checked == true))
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                   
            }
            else
            {
                textBox1.Font = new Font("Ariel", 10, FontStyle.Regular);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
        }
    }
}
