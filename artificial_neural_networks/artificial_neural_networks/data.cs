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

        //Toplama işlemleri. için seçim fonk.
        public double secim_toplama(string toplama_fonk, int parametre_sayisi)
        {
            double islem_sonucu = 0.0;

            switch (toplama_fonk)
            {
                case "∑":
                    islem_sonucu = I_normal_toplama(toplama_fonk, parametre_sayisi);                    
                    break;
                case "Π":
                    islem_sonucu = I_carpma(toplama_fonk , parametre_sayisi);
                    break;
                default:
                    break;
            }
            return islem_sonucu;
        }

        //Aktivasyon işlemleri. için seçim fonk.
        public double secim_aktivasyon(string aktivasyon_fonk)
        {
            double islem_sonucu = 0.0;

            switch (aktivasyon_fonk)
            {
                case "Sigmoid":
                    islem_sonucu = sigmoid();
                    break;
                case "Hyperbolic":
                    islem_sonucu = hyperbolic();
                    break;
                default:
                    break;
            }
            return islem_sonucu;
        } 

        #region aktivasyon fonksiyonları
        public double sigmoid()
        {
            double S = 0.0;

            double ust_ifade = Math.Pow(Math.E, -toplam);
            
            S = 1 / (1 + ust_ifade);

            return S;
        }

        public double hyperbolic()
        {
            double H = 0.0;

            double ust_ifade = Math.Pow(Math.E , - (2 * toplam));
            double alt_ifade = Math.Pow(Math.E , + (2 * toplam));

            H = (1 - ust_ifade) / (1 + alt_ifade);

            return H;
        }
        #endregion

        // normal toplama metodu :interface
        public double I_normal_toplama(string toplama_fonk, int parametre_sayisi)
        {
            toplam = 0.0;

            for (int j = 0; j < parametre_sayisi; j++)
            {
                toplam += girdiler[j, 0] * girdiler[j, 1];
            }

            return toplam;
        }

        // carparak toplam fonk hesaplama
        public double I_carpma(string carpma_fonk, int parametre_sayisi)
        {
            toplam = 1.0;

            for (int j = 0; j < parametre_sayisi; j++)
            {
                toplam *= girdiler[j, 0] * girdiler[j, 1];
            }

            return toplam;
        }
    }
}
