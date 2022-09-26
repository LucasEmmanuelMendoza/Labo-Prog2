using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEJA01
{
    internal class Conductor
    {
        private string nombre;
        private float[] kmRecorridos = new float[7];
        
        public Conductor()
        {
            this.nombre = "Sin nombre";
            
            for(int i =0; i<kmRecorridos.Length; i++)
            {
                this.kmRecorridos[i] = 0;
            }
        }

        public Conductor(string nombre, float[] kmRecorridos)
        {
            this.nombre = nombre;

            for(int j =0; j<kmRecorridos.Length; j++)
            {
                this.kmRecorridos[j] = kmRecorridos[j];
            }
        }

        public float CalcularMayorCantKmTotal(Conductor[] conductores)
        {
            float mayor = 0;
            float suma = 0;

            for(int i=0; i<conductores.Length; i++)
            {
                for(int j=0; j<7; j++)
                {
                    suma += this.kmRecorridos[j];
                }

                if(i == 0)
                {
                    mayor = suma;
                }
                else
                {
                    if(suma > mayor)
                    {
                        mayor = suma;
                    }
                }
            }

            return mayor;
        }

        public float CalcularMayorCantKmPorDia(Conductor[] conductores, int dia)
        {
            float retorno = 0;
            float mayor = 0;

            for(int i=0; i<conductores.Length; i++)
            {
                retorno = conductores[i].kmRecorridos[dia];

                if(retorno > mayor)
                {
                    mayor = retorno;
                }
            }

            return mayor;
        }

        public string MostrarConductorMayorKmPorDia(Conductor[] conductores, int dia)
        {
            float mayorPorDia;
            StringBuilder sb = new StringBuilder();

            mayorPorDia = CalcularMayorCantKmPorDia(conductores, dia);

            for(int i = 0; i<conductores.Length; i++)
            {
                if (conductores[i].kmRecorridos[dia] == mayorPorDia)
                {
                    sb.Append($"{conductores[i]}\n");
                }
            }

            return sb.ToString();
        }
    }
}
