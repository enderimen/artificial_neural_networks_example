using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artificial_neural_networks
{
    class data:activation_functions
    {
        private int agirlik;

        public void setAgirlik(int agirlik)
        {
            this.agirlik = agirlik;
        }

        public int getAgirlik()
        {
            return agirlik;
        }

        double activation_functions.sigmoid(int x)
        {
            double ust = Math.Pow(Math.E, -x);
            double F = 1 / (1 + ust);

            return F;
        }
    }
}
