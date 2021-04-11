using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string constring = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=Test;Integrated Security=True";

       private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring)  ;
            con.Open();
            if (con.State == System.Data.ConnectionState.Open) ;
            string s="insert into Test(Id,Name)values('"+txtId.Text.ToString()+"','"+txtName.Text.ToString()+"')";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Successfully");
        }
    }
}
