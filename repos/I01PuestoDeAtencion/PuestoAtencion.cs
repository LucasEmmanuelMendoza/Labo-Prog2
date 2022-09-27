using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01PuestoDeAtencion
{
    internal class PuestoAtencion
    {
        private static int numeroActual;
        private Enumerados.Puesto puesto;

        public int NumeroActual
        {
            get { return numeroActual+1; }
        }

        public static bool Atender(Cliente cli)
        {
            bool retorno;
            retorno = false;
            
            if(cli is not null)
            {
                Thread.Sleep(7);
                retorno = true;
            }

            return retorno;
        } 

        private PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Enumerados.Puesto puesto) :this()
        {
            this.puesto = puesto;
        }

    }

    internal class Enumerados
    {
        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
