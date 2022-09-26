using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej01Clases
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno;

            retorno = false;

            if(valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
