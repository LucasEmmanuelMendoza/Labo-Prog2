using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01Sumador
{
    internal class Sumador
    {
        int cantidadSumas;

        public Sumador(int valor)
        {
            this.cantidadSumas = valor;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            long retorno;

            retorno = a + b;

            this.cantidadSumas++;

            return retorno;
        }

        public string Sumar(string a, string b)
        {
            StringBuilder retorno = new StringBuilder();

            this.cantidadSumas++;

            retorno.AppendLine($"{a} {b}");

            return retorno.ToString();
        }

        public static long operator +(Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            bool retorno;

            retorno = false;

            if (a.cantidadSumas == b.cantidadSumas)
            {
                retorno = true;    
            }

            return retorno;
        }
    }
}
