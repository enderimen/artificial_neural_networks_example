using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artificial_neural_networks
{
    class data:activation_functions,sum_functions
    {
        private int agirlik;
        private double[,] girdiler;

        double toplam = 0.0;
        Random agirlik_uret = new Random();
        Random bagimsiz_degiskenler = new Random();  

        public void setAgirlik(int agirlik)
        {
            this.agirlik = agirlik;
        }

        public int getAgirlik()
        {
            return agirlik;
        }

        public void setGirdiler(int parametreSayisi,int alt_sinir, int ust_sinir)
        {
            girdiler = new double[parametreSayisi, 2];

            for (int i = 0; i < parametreSayisi; i++)
            {
                int b = bagimsiz_degiskenler.Next(alt_sinir,ust_sinir);

                for (int k = 0; k < 2; k++)
                {
                    if (k % 2 == 0)
                    {
                        girdiler[i, k] = b;
                        //listBox1.Items.Add(girdi[i, k]);
                    }
                    else
                    {
                        girdiler[i, k] = agirlik_uret.NextDouble();
                        //listBox2.Items.Add(girdi[i, k]);
                    }
                }
            }
        }

        public double[,] getGirdiler(){
            return girdiler;
        }

        // sigmoid metodu :interface
        public double sigmoid(string activation_function)
        {
            double F = 0.0;
            switch (activation_function)
            {
                case "Sigmoid":

                    double ust_ifade = Math.Pow(Math.E, -toplam);
                    F = 1 / (1 + ust_ifade);

                    break;
                default:
                    break;
            }
            return F;
        }


        // normal toplama metodu :interface
        public double I_normal_toplama(string toplama_fonk, int parametre_sayisi)
        {
            bool error = false;
            switch (toplama_fonk)
            {
                case "∑":

                    for (int j = 0; j < parametre_sayisi; j++)
                    {
                        toplam += girdiler[j, 0] * girdiler[j, 1];
                    }
                    break;
                case "a":
                    error = true;

                    //MessageBox.Show("İşlem tanımlanmadı");
                    break;
                default:
                    break;
            }

            if (error==true)
            {
                return 1;
            }
            return toplam;
        }
    }
}
