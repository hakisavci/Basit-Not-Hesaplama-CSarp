using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vize = textBox1.Text;
            string final = textBox2.Text;

            int v = Convert.ToInt32(vize);
            int f = Convert.ToInt32(final);

            double sonuc = (v * 0.3 + f * 0.7);

            if (sonuc >= 50)
            {
                label4.Text = "SONUÇ : " + "GEÇTİ";
            }
            else
            {
                label4.Text = "SONUÇ: " + "KALDI";
            }

            label3.Text = "ORTALAMA : " + sonuc.ToString();



            if (sonuc >= 50 && sonuc < 60)
            {
                label5.Text = "HARF NOTU : " + "CC";
            }
            if (sonuc >= 60 && sonuc <= 75)
            {
                label5.Text = "HARF NOTU : " + "CB";
            }
            if (sonuc > 70 && sonuc <= 85)
            {
                label5.Text = "HARF NOTU : " + "BB";
            }
            if (sonuc > 85 && sonuc <= 100)
            {
                label5.Text = "HARF NOTU : " + "AA";
            }
            if(sonuc<35)
            {
                label5.Text = "HARF NOTU : " + "FF";
            }


        }

        }
    }
