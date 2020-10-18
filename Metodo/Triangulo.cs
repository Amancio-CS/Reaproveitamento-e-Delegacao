using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double P = (A + B + C);
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
}
