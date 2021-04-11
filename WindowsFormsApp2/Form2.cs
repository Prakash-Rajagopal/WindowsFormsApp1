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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static Boolean Chk(int a, int b)
        {
            return a < 100 && b < 100 ? true : false;
        }

        private static int vow(string s)
        {
            int count = 0;

            foreach (char letter in s)
            {
                switch (letter)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }

            }

            return count;
        }
        private static string[] tim(string t)
        {
            string[] splittim = t.Split(':');
            return splittim;
        }

        private static bool Dupchk(List<int> nu)
        {
            return nu.GroupBy(n => n).Any(duplicate => duplicate.Count() > 1);
        }

        private static int Rand(int a, int b)
        {
            if (Chk(a, b))
            {
                var random = new Random();
                return random.Next(a, b);
            }
            else
            {
                return 0;
            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            string input = txtName.Text;
            int ctr = vow(input);
            if (ctr >= 3)
            {
              MessageBox.Show("You have got one more chance!!!");
            }
            else
            {
                MessageBox.Show("Better Luck Next Time!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          int c = Rand(Convert.ToInt32(txtRand1.Text), Convert.ToInt32(txtRand2.Text));
            txtRes.Text=Convert.ToString(c);
            //     Console.WriteLine("Random number is {0}", c);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var num = txtDup.Text;
            var nums = num.Split('-').Select(n => Convert.ToInt32(n)).ToList();
            MessageBox.Show(Dupchk(nums) ? "Duplicate Exist" : "Has No Duplicates");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string t1 = txtTime.Text;
            string[] tims = tim(t1);
            txtHour.Text = tims[0];
            txtMin.Text = tims[1];
        }
    }
}
