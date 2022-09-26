using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace I02Cotizador
{
    internal class Euro
    {
        private double cantidad;
        static double cotzRespectoDolar;

        private Euro()
        {
            this.cantidad = 0;
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        { 
            //Dolar retorno = new Dolar(e.GetCantidad() * Dolar.GetCotizacion());
            Dolar retorno = new Dolar(e.GetCantidad() * Euro.GetCotizacion());

            return retorno;
        }

        public static explicit operator Pesos(Euro e)
        {
            double cotPesoRespectEuro;
            
            cotPesoRespectEuro = Pesos.GetCotizacion()/ Euro.cotzRespectoDolar;

            Pesos retorno = new Pesos(e.cantidad * cotPesoRespectEuro);

            return retorno;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.cantidad == d.GetCantidad());
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.cantidad == p.GetCantidad());
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new (((Euro)d).GetCantidad() - e.GetCantidad());
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new (((Euro)p).GetCantidad() - e.GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new (((Euro)d).GetCantidad() + e.GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(((Euro)p).GetCantidad() + e.GetCantidad());
        }
    }
}
