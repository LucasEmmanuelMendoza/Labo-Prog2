using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02Clases
{
    public static class Validador
    {
        public static bool ValidarRespuesta(char rta)
        {
            bool retorno;

            retorno = false;

            if(rta == 'S')
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
