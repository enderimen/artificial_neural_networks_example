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

            
            if (data1.I_normal_toplama(toplama_fonk.Text, parametre_sayisi) != 1)
            {
                label6.Text += data1.I_normal_toplama(toplama_fonk.Text, parametre_sayisi);
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Toplama işlemi tanımlanamadı.");
                label6.Text += 0;
            }


            label7.Text += data1.sigmoid(aktivasyon_fonk.Text);

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
            if (parametre_sayisi.Text != null && ust_sinir.Value != 0 && alt_sinir.Value != 0 && toplama_fonk.Text != ""  && aktivasyon_fonk.Text != "")
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
    }
}
