using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01PuestoDeAtencion
{
    internal class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get{
                return clientes.Dequeue();
            }
            set{
                if (!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        private Negocio()
        {
            //this.nombre = "Sin nombre";
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Enumerados.Puesto.Caja1);
        }

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            return (n.clientes.Contains(c));
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno;
            retorno = false;

            if (!(n == c))
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno;
            retorno = false;

            if(n.clientes.Count > 0)
            {
                retorno = (PuestoAtencion.Atender(n.clientes.Dequeue()));
            }

            return retorno;
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
    }
}
