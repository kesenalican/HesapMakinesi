using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi1 = 0;
        double sayi2 = 0;
        bool tiklandi = false;
        bool sonucTiklandimi = false;
        String islem;

        private void button15_Click(object sender, EventArgs e)
        {
            if (tiklandi == true)
            {
                textBox1.Clear();
                tiklandi = false;
            }
            label1.Text = "";
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void butonTopla_Click(object sender, EventArgs e)
        {
            if (sayi1 == 0)
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            else if (sonucTiklandimi == false)
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
                sayi1 += sayi2;
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            islem = "topla";
            tiklandi = true;
            sonucTiklandimi = false;
        }

        private void butonCikar_Click(object sender, EventArgs e)
        {
            if (sayi1 == 0)
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            else if (sonucTiklandimi == false)
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
                sayi1 -= sayi2;
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            islem = "cikart";
            tiklandi = true;
            sonucTiklandimi = false;

        }

        private void butonCarp_Click(object sender, EventArgs e)
        {
            if (sayi1 == 0)
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            else if (sonucTiklandimi == false)
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
                sayi1 *= sayi2;
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            islem = "carp";
            tiklandi = true;
            sonucTiklandimi = false;
        }

        private void butonBolme_Click(object sender, EventArgs e)
        {
            if (sayi1 == 0)
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            else if (sonucTiklandimi == false)
            {
                sayi2 = Convert.ToDouble(textBox1.Text);
                sayi1 /= sayi2;
                textBox1.Text = sayi1.ToString();
            }
            else
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
            }
            islem = "bol";
            tiklandi = true;
            sonucTiklandimi = false;
        }

        private void butonEsit_Click(object sender, EventArgs e)
        {
            if (sayi2 == 0)
            {
                if (islem == "topla")
                {
                    sayi1 += Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }
                else if (islem == "cikart")
                {
                    sayi1 -= Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }
                else if (islem == "bol")
                {
                    sayi1 /= Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();

                }
                else if (islem == "carp")
                {
                    sayi1 *= Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }

            }
            else
            {
                if (islem == "topla")
                {
                    sayi1 += Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }
                else if (islem == "cikart")
                {
                    sayi1 -= Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }
                else if (islem == "carp")
                {
                    sayi1 *= Convert.ToDouble(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text = sayi1.ToString();
                }    
            }
            tiklandi = true;
            sonucTiklandimi = true;
            
        }

        private void butonVirgul_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
    }
}
