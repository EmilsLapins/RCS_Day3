using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Degviela
    {
        
        public double DegvielasPaterins(double a, double b, double c)  // paterins, cena, distance.
        {

            double Kilometrs = a / 100;
            double DegvielaKopa = Kilometrs * c;
            double Atrsinajums = DegvielaKopa * b;
            return Atrsinajums;


        }
    }
}
