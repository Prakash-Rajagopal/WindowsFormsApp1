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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to New Job!!!");
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (txtName.Text == txtPass.Text)
            {
                MessageBox.Show("Login Successful");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
