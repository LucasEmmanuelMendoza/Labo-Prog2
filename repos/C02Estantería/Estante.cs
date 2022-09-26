using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02Estantería
{
    internal class Estante
    {
        //codigo de barra - marca - precio
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
             productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) :this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Ubicación: {e.ubicacionEstante}");

            for (int i=0; i<e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));

                //sb.Append(MostrarProducto(new Producto (e.productos[i]))); MAAAAL
                //sb.Append(Producto.MostrarProducto(e.productos[i]));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;

            for(int i=0; i<e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno;

            retorno = false;

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for(int i=0; i<e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            
            return e;
        }
    }
}
