using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej04Clases
{
    internal class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, char operacion)
        {
            float retorno=0;
            bool retornoValidar;

            switch (operacion){
                
                case '+':
                    retorno = primerOperando + segundoOperando;
                    break;

                case '-':
                    retorno = primerOperando - segundoOperando;
                    break;

                case '*':
                    retorno = primerOperando * segundoOperando;
                    break;

                case '/':
                    if(Validar(segundoOperando) == true)
                    {
                        retorno = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }
                    break;
            }

            return retorno;
        }

        private static bool Validar (float segundoOperando)
        {
            bool retorno;

            retorno = false;

            if(segundoOperando != 0)
            {
                retorno = true;     
            }

            return retorno;
        }
    }
}
