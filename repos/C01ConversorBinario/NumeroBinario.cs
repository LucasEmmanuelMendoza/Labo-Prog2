using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace C01ConversorBinario
{
    internal class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string num)
        {
            this.numero = num;
        }

        public string GetNum()
        {
            return this.numero;
        }

        /*
        public static explicit operator string(NumeroDecimal n1)
        {
            return n1.GetNum();

        }*/

        public static explicit operator string(NumeroBinario n1)
        {
            return n1.numero;
        }

        public static implicit operator NumeroBinario(string n1)
        {
            return new NumeroBinario(n1);
        }

        public static string operator +(NumeroBinario n1, NumeroDecimal n2)
        {
            string retorno = "Error";
            double aux=0;
            if (n1 is not null && n2 is not null)
            {
                aux = Conversor.ConvertirBinarioADecimal(int.Parse(n1.GetNum())) + n2.GetNum();
                Console.WriteLine($"Aux: {aux}");
                retorno = Conversor.ConvertirDecimalABinario((int)aux);
            }

            return retorno;
        }

        public static string operator -(NumeroBinario n1, NumeroDecimal n2)
        {
            double aux=0;

            if (n1 is not null && n2 is not null)
            {
                aux = n2.GetNum() - Conversor.ConvertirBinarioADecimal(int.Parse(n1.GetNum()));
            }

            return aux.ToString();
        }

        public static bool operator ==(NumeroBinario n1, NumeroDecimal n2)
        {
            bool retorno = false;

            if (n1 is not null && n2 is not null)
            {
                retorno = Conversor.ConvertirBinarioADecimal(int.Parse(n1.GetNum())) == n2.GetNum();
            }

            return retorno;

        }
        public static bool operator !=(NumeroBinario n1, NumeroDecimal n2)
        {
            return !(n1 == n2); 
        }
    }
}
