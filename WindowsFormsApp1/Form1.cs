using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public double sayi1 , islem=0, sonuc;
        public string sembol_kontrol;

        public void hesapla(string sembol)
        {
            if (islem == 0)
            {
                islem = 1;
                sonuc = Convert.ToDouble(richTextBox1.Text.ToString());
                richTextBox1.Clear();
            }
            else
            {
                sayi1 = Convert.ToDouble(richTextBox1.Text.ToString());
                if (sembol == '/'.ToString())
                {
                    sonuc = sonuc / sayi1;
                }
                else if (sembol == '-'.ToString())
                { sonuc = sonuc - sayi1; }
                else if (sembol == '+'.ToString())
                { sonuc = sonuc + sayi1; }
                else if (sembol == '*'.ToString())
                { sonuc = sonuc * sayi1; }
                else if (sembol == '='.ToString())
                {
                    if (sembol_kontrol == '/'.ToString())
                    {
                        sonuc = sonuc / sayi1;
                    }
                    else if (sembol_kontrol == '-'.ToString())
                    { sonuc = sonuc - sayi1; }
                    else if (sembol_kontrol == '+'.ToString())
                    { sonuc = sonuc + sayi1; }
                    else if (sembol_kontrol == '*'.ToString())
                    { sonuc = sonuc * sayi1; }
                    richTextBox1.Text = sonuc.ToString();
                }
                else if (sembol_kontrol == '%'.ToString())
                {
                    sonuc = (sonuc * sayi1) / 100;
                    richTextBox1.Text = sonuc.ToString();
                }

                richTextBox1.Text = sonuc.ToString();
                islem = 0;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }            
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sembol_kontrol = '*'.ToString();
                hesapla('*'.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sembol_kontrol = '-'.ToString();
                hesapla('-'.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sembol_kontrol = '+'.ToString();
                hesapla('+'.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                hesapla('='.ToString());
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                richTextBox1.Text = '-'.ToString();
            }
            else
            {
                string karakter = richTextBox1.Text.Substring(0, 1);

                if (karakter == '-'.ToString())
                {
                    richTextBox1.Text = richTextBox1.Text.Split('-').Last();
                }
                else
                {
                    richTextBox1.Text = '-' + richTextBox1.Text;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                richTextBox1.Text = Convert.ToString(1 / Convert.ToDouble(richTextBox1.Text.ToString()));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sayi1 = 0;
                sonuc = 0;
                richTextBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sayi1 = 0;
                richTextBox1.Clear();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                richTextBox1.Text = Convert.ToString((Convert.ToDouble(richTextBox1.Text.ToString())) * (Convert.ToDouble(richTextBox1.Text.ToString())));
            }
            }

        private void button23_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                richTextBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToInt32(richTextBox1.Text.ToString())));
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + ".";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else 
            {
                sembol_kontrol = '%'.ToString();
                hesapla('%'.ToString());
            }
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
            }
            else
            {
                sembol_kontrol = '/'.ToString();
                hesapla('/'.ToString());
            }
        }
    }
}
