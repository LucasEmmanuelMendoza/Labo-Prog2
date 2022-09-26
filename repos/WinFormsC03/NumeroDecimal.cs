using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsC03
{
    internal class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNum()
        {
            return this.numero;
        }

        public static explicit operator double(NumeroDecimal n1)
        {
            return n1.numero;
        }

        public static implicit operator NumeroDecimal(double n1)
        {
            return new NumeroDecimal(n1);
        }

        public static double operator +(NumeroDecimal n1, NumeroBinario n2)
        {
            double retorno;

            retorno = n1.GetNum() + Conversor.ConvertirBinarioADecimal(int.Parse(n2.GetNum()));

            return retorno;
        }
        public static double operator -(NumeroDecimal n1, NumeroBinario n2)
        {
            double retorno;

            retorno = n1.GetNum() - Conversor.ConvertirBinarioADecimal(int.Parse(n2.GetNum()));

            return retorno;
        }

        public static bool operator ==(NumeroDecimal n1, NumeroBinario n2)
        {
            return (n1.GetNum() == int.Parse(n2.GetNum()));
        }
        public static bool operator !=(NumeroDecimal n1, NumeroBinario n2)
        {
            return !(n1 == n2);
        }
    }
}
