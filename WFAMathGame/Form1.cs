using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int op,dogruCevapSayisi,yanlisCevapSayisi,soruSayisi;
        int gecensure = 10;
        int seviye = 1;
        

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            gecensure--;
            lblGecenSure.Text = gecensure.ToString();
            if (gecensure<=0)
            {
                gecensure = 10;
                soruSayisi++;
                lblSoruSayisi.Text = soruSayisi.ToString();
                lblGecenSure.Text = gecensure.ToString();
                double sayi1 = rnd.Next(1, 11);
                lblSayi1.Text = sayi1.ToString();
                double sayi2 = rnd.Next(1, 11);
                lblSayi2.Text = sayi2.ToString();

                op = rnd.Next(1, 5);
                if (op == 1)
                {
                    lblOperator.Text = "+";
                }
                else if (op == 2)
                {
                    lblOperator.Text = "-";

                }
                else if (op == 3)
                {
                    lblOperator.Text = "*";
                }
                else
                {
                    lblOperator.Text = "/";
                }
            }
            else
            {
                gecensure--;
                lblGecenSure.Text = gecensure.ToString();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrKronometre.Start();
            double sayi1 = rnd.Next(1, 11);
            lblSayi1.Text = sayi1.ToString();
            double sayi2 = rnd.Next(1, 11);
            lblSayi2.Text = sayi2.ToString();

            op = rnd.Next(1, 5);
            if(op==1)
            {
                lblOperator.Text = "+";
            }
            else if(op==2)
            {
                lblOperator.Text = "-";

            }
            else if(op==3)
            {
                lblOperator.Text = "*";
            }
            else
            {
                lblOperator.Text = "/";
            }
            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi1 = Convert.ToDouble(lblSayi1.Text);
                double sayi2 = Convert.ToDouble(lblSayi2.Text);
                double girilensonuc = Convert.ToDouble(txtSonuc.Text);
                double sonuc = 0;
                
                if (op == 1)
                {
                    sonuc = sayi1 + sayi2;
                }
                else if (op == 2)
                {
                    sonuc = sayi1 - sayi2;
                }
                else if (op == 3)
                {
                    sonuc = sayi1 * sayi2;
                }
                else
                {
                    sonuc = sayi1 / sayi2;
                }
                if (girilensonuc == sonuc)
                {
                    dogruCevapSayisi++;
                    lblDogruSayisi.Text = dogruCevapSayisi.ToString();

                    seviye++;
                    lblSeviye.Text = seviye.ToString();
                }
                else
                {
                    yanlisCevapSayisi++;
                    lblYanlisSayisi.Text = yanlisCevapSayisi.ToString();
                   
                }
                
                soruSayisi++;
                lblSoruSayisi.Text = soruSayisi.ToString();

                sayi1 = rnd.Next(1, 11*seviye);
                lblSayi1.Text = sayi1.ToString();
                sayi2 = rnd.Next(1, 11*3);
                lblSayi2.Text = sayi2.ToString();

                op = rnd.Next(1, 5);
                if (op == 1)
                {
                    lblOperator.Text = "+";
                }
                else if (op == 2)
                {
                    lblOperator.Text = "-";

                }
                else if (op == 3)
                {
                    lblOperator.Text = "*";
                }
                else
                {
                    lblOperator.Text = "/";
                }
                txtSonuc.Text = null;
                txtSonuc.Focus();

            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen Sayısal Değerler Giriniz.");
            }
           
           
        }
    }
}
