using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01ConversorBinario
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder sb = new StringBuilder();
            int division = numeroEntero / 2;
            int resto = numeroEntero % 2;
            string retorno;

            while (resto != 0 || division != 0)
            {
                //Console.WriteLine("Divison:{0}", division);
                //Console.WriteLine("Resto: {0}", resto);
                sb.Append(resto.ToString());

                resto = division % 2;
                division = division / 2;
            }

            retorno = InvertirManualmente(sb.ToString());

            return retorno;
        }
        public static string InvertirManualmente(string cadena)
        {
            string cadenaInvertida = "";
            // Recorrer cadena letra por letra
            foreach (char letra in cadena)
            {
                // Anteponer la letra a la cadena invertida
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroEnteroStr;
            int exp = 0;
            int acumulador = 0;
            int numero;

            numeroEnteroStr = numeroEntero.ToString();
            //Console.WriteLine($"Numero entero str lenght: {numeroEnteroStr.Length}");
            //OJO con el tamaño del array. 11001 es de tamaño 5, pero si yo recorro desde la posición 0 hasta la 5, me estaría moviendo 6 lugares:0,1,2,3,4,5
            //por lo que me estaría pasando de los límites del array, ya que no existe la posición 5 en el string "11001".

            for (int i = numeroEnteroStr.Length - 1; i >= 0; i--)
            {
                numero = int.Parse(numeroEnteroStr[i].ToString());
                acumulador += numero * (int)Math.Pow(2, exp);
                exp++;
            }

            return acumulador;
        }
    }
}
