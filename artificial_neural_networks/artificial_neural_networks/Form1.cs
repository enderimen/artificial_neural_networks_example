using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artificial_neural_networks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void hesapla()
        {
            
            data data1 = new data();

            int parametre_sayisi = 5;

            decimal alt = alt_sinir.Value;
            decimal ust = ust_sinir.Value;

            data1.setGirdiler(parametre_sayisi, (int)alt, (int)ust);

            // Normal Toplama Fonksiyonu
            if (data1.secim_toplama(toplama_fonk.Text, parametre_sayisi) != 1)
            {
                label6.Text = "Toplama fonk. sonucu: " + data1.secim_toplama(toplama_fonk.Text, parametre_sayisi);
            }
            else
            {
                label6.Text = "Toplama fonk. sonucu: İşlem tanımlanamadı";
            }


            //Çarpım sembolü kullanarak toplma işlemi
            if (data1.secim_toplama(toplama_fonk.Text, parametre_sayisi) != 1)
            {
                label6.Text = "Toplama fonk. sonucu: " + data1.secim_toplama(toplama_fonk.Text, parametre_sayisi);
            }
            else
            {
                label6.Text = "Toplama fonk. sonucu: İşlem tanımlanamadı";
            }


            label7.Text = "Aktivasyon fonk. sonucu: " + data1.secim_aktivasyon(aktivasyon_fonk.Text);

            double[,] gelen_girdiler = data1.getGirdiler();

            for (int i = 0; i < parametre_sayisi; i++)
            {
                   listBox1.Items.Add(gelen_girdiler[i, 0]);
                   listBox2.Items.Add(gelen_girdiler[i, 1]);
            }
        }

        private void hesapla_buton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            if (parametre_sayisi.Text != "0" && ust_sinir.Value != 0 && alt_sinir.Value != 0 && toplama_fonk.Text != ""  && aktivasyon_fonk.Text != "")
            {
                if (alt_sinir.Value < ust_sinir.Value)
                {
                    hesapla();
                }
                else
                {
                    MessageBox.Show("Alt sınır üst sınırdan büyük olamaz");
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void temizle()
        {
            parametre_sayisi.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ust_sinir.Value = 0;
            alt_sinir.Value = 0;

            toplama_fonk.Text = "";
            aktivasyon_fonk.Text = "";

            label6.Text = "Toplama fonk. sonucu: ";
            label7.Text = "Aktivasyon fonk. sonucu: ";
        }
    }
}
