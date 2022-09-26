using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace I02Cotizador
{
    internal class Dolar
    {
        private double cantidad;
        static double cotzRespectoDolar;

        private Dolar()
        {
            this.cantidad = 0;
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) :this()
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static explicit operator Euro (Dolar d) 
        {
            /*
            Euro retorno = new Euro();
            double cant;

            cant = d.cantidad / Euro.GetCotizacion();

            retorno = new Euro(cant);

            return retorno; */

            return new Euro(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos (Dolar d)
        {
            /*
            Pesos retorno = new Pesos();
            double cant;

            cant = d.cantidad * Pesos.GetCotizacion();

            retorno = new Pesos(cant);

            return retorno; */

            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            Dolar retorno = new Dolar(d);

            return retorno;
        }

    public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.GetCantidad();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.cantidad == p.GetCantidad();
        } 
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);

        }
        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);

        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar();

            retorno = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());

            return retorno;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar();

            retorno = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());

            return retorno;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }


    }
}
