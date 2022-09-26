using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02Cotizador
{
    internal class Pesos
    {
        private double cantidad;
        static double cotzRespectoDolar;

        private Pesos()
        {
            this.cantidad = 0;
            cotzRespectoDolar = 0.0097;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            //1 dólar = 102.65 pesos
            //return new Dolar(p.GetCantidad()/Pesos.GetCotizacion());

            return new Dolar(p.GetCantidad() * Pesos.GetCotizacion());

        }

        public static explicit operator Euro(Pesos p)
        {
            //1 euro= 120.10 pesos
            //return new Euro(p.GetCantidad() / 120.10);
            //return new Dolar(Pesos.GetCotizacion() / Euro.GetCotizacion());
            double cotzPesoRespEuro;

            cotzPesoRespEuro = Dolar.GetCotizacion() / Euro.GetCotizacion();

            return new Euro(p.GetCantidad() * cotzPesoRespEuro);

        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad();
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p.GetCantidad() == e.GetCantidad();
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p1.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
        }

    }
}
