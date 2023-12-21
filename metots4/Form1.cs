using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metots4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int toplam(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        
        private int kupbul(int s1)
        {
            int sonuc = s1 * s1 * s1;
            return sonuc;
        }

        private int dıkcevre(int a,int b)
        {
            int dıksonuc = 2 * (a + b);
            return dıksonuc;
        }
        
        private int dikalan(int d, int e)
        {
            int dikalansonuc = d * e;
            return dikalansonuc;
        }
        private double daireAlan(double r, double r1)
        {
            double daireAlanSonuc = r1* (r * r);
            return daireAlanSonuc;
        }

        private double DaireCevre(double q, double q1)
        {
            double d1s = 2 * (q * q1);
            return d1s;
        }


    /*************************************************************************************************************************************************************/


        private void button1_Click(object sender, EventArgs e)
        {
                      
            int sayi = Convert.ToInt32(textBox1.Text);
            label4.Text = kupbul(sayi).ToString();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            btnDıkCevre.Enabled = false;
            button1.Enabled = false;
        }

        private void btnDıkCevre_Click(object sender, EventArgs e)
        {
            int sayia = Convert.ToInt32(textBox2.Text);
            int sayib = Convert.ToInt32(textBox3.Text);
            lblDıkCevre.Text = dıkcevre(sayia,sayib).ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnDıkCevre.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btnDıkCevre.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int dikuzun = Convert.ToInt32(textBox4.Text);
            int dikkisa = Convert.ToInt32(textBox5.Text);
            label11.Text = dikalan(dikkisa, dikuzun).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi9 = Convert.ToDouble(textBox7.Text);
            double say10 = Convert.ToDouble(textBox6.Text);
            label3.Text = daireAlan(sayi9,say10).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double sayi15 = Convert.ToDouble(textBox9.Text);
            double sayi16 = Convert.ToDouble(textBox8.Text);
            label16.Text = DaireCevre(sayi15, sayi16).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button9.Enabled = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            button9.Enabled = true;
        }
    }
}
