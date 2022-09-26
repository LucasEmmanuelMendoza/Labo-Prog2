using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01NumLocos
{
    internal class ClaseRandom
    {
        public static double[] GenerarNums()
        {
            var ran = new Random();
            double[] numeros = new double[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = ran.Next(-1000, 1000);
                while (numeros[i] == 0)
                {
                    numeros[i] = ran.Next();
                }

                Console.WriteLine(numeros[i]);
            }

            return numeros;
        }
        
        public static double[] OrdenarPositivos(double[] arrayNums)
        {
            double[] retorno = new double[arrayNums.Length];
            double aux=0;

            if (arrayNums is not null)
            {
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    if (arrayNums[i] > 0)
                    {
                        retorno[i] = arrayNums[i];
                    }
                }
            }

            /**/for(int j=0; j<retorno.Length-1; j++)
            {
                for(int k=j+1; k<retorno.Length; k++)
                {
                    if (retorno[j] < retorno[k])
                    {
                        aux = retorno[j];
                        retorno[j] = retorno[k];
                        retorno[k] = aux;
                    }
                }
            }

            return retorno;
        }

        public static double[] OrdenarNegativos(double[] arrayNums)
        {
            double[] retorno = new double[arrayNums.Length];
            double aux = 0;

            if (arrayNums is not null)
            {
                for (int i = 0; i < arrayNums.Length; i++)
                {
                    if (arrayNums[i] < 0)
                    {
                        retorno[i] = arrayNums[i];
                    }
                }
            }

            /**/
            for (int j = 0; j < retorno.Length - 1; j++)
            {
                for (int k = j + 1; k < retorno.Length; k++)
                {
                    if (retorno[j] > retorno[k])
                    {
                        aux = retorno[j];
                        retorno[j] = retorno[k];
                        retorno[k] = aux;
                    }
                }
            }

            return retorno;
        }

    }
}
