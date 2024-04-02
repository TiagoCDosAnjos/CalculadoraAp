using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    internal class Calculadora
    {
        public double Soma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

         public double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

         public double Dividir(double numero1, double numero2)
        {
            return numero1 / numero2;
        }

         public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}
