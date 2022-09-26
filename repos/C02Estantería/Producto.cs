using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C02Estantería
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Marca: {p.marca}");
            sb.Append($"Precio: {p.precio}");

            return sb.ToString();
        }

        public static explicit operator string(Producto producto)
        { 
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno;
            retorno = false;

            if (p.marca == marca)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno;
            retorno = false;

            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

    }
}
