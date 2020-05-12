using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double a(int n)
        {
            if (n == 1) return 1;

            else return (a(n / 2) + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(Nn.Text);
                if (n > 0)
                { rez.Text=Convert.ToString("a = " + a(n)); }
                else rez.Text = Convert.ToString("Число должно быть больше 0!");
            }
            catch { rez.Text = Convert.ToString("Некорректный ввод!"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            Nn.Clear();
        }
    }
}
