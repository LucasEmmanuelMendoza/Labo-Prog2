using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02NumLocos2Listas
{
    internal class Ordenar
    {
        public static List<double> CargarNumeros (List <double> lista, int tam)
        {
            var rand = new Random ();

            for(int i=0; i<tam; i++)
            {
                lista.Add (rand.Next(-1000, 1000));//                lista.Add ((double)rand.Next());??

            }

            return lista;
        }

        public static List<double> OrdenarPositivos(List <double> lista)
        {
            List<double> positivos = new List<double>();
            double aux = 0;

            foreach (var item in lista)
            {
                if(item > 0)
                {
                    positivos.Add (item);
                }
            }

            positivos.Sort();
            
            return positivos;
        }

        public static List<double> OrdenarNegativos(List<double> lista)
        {
            List<double> negativos = new List<double>();
            double aux = 0;

            foreach (var item in lista)
            {
                if (item < 0)
                {
                    negativos.Add(item);
                }
            }

            negativos.Reverse();

            return negativos;
        }
    }
}
