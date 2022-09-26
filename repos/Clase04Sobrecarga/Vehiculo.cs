using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase04Sobrecarga
{
    internal class Vehiculo
    {
        string marca;
        string color;
        int listrosNafta;
        int puertas;

        //Sobrecarga de constructores
        public Vehiculo()
        {
            this.puertas = puertas;
            this.marca = "marca";
            this.color = "color";
            this.listrosNafta = 1000;
            //Estos valores los va pisando a medida que se va ejecutando los otros 
        }
        public Vehiculo(int puertas) : this()// o : thsis(0), es decir, le pasamos el valor por parámetro
        {
            this.puertas = puertas;
            this.marca = "marca";
            this.color = "color";
            this.listrosNafta = 1000;
            //Estos valores los va pisando a medida que se va ejecutando los otros 
        }

        public Vehiculo(string marca, int puertas) : this(puertas)
        {
            this.marca = marca;
        }
        public Vehiculo(string marca, int puertas, string color) : this(marca, puertas)
        {
            this.color = color;
        }
        public Vehiculo(string marca, int puertas, string color, int litrosNafta) : this(marca, puertas, color)
        {
            this.listrosNafta = litrosNafta;
        }

        //Así podemos instanciar de distintas maneras
        //Siempre se ejecuta el this primero y luego lo que está dentro de las llaves

        //Propiedades: Set y Get. Sin paréntesis:
        /*public string Color
        {
            get { return this.color; }
            set { this.color = value; }

            //Al llamarlo en el main:
            //v2.Color = "rojo"; SET
            //v1.color = v2.color; GET
            //Console.WriteLine (v1.Mostrar());
        }*/

        public string Color
        {
            get { return this.color; }
            set
            {
                if (value != null)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "rojo";
                }
            }
        }

        //------------------------------------------------------------------------------------
        //Sobrecarga de métodos:
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Puertas: {this.puertas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"LitrosNafta: {this.listrosNafta}");

            return sb.ToString();
        }

        public string Mostrar(int numero1) //acá no puedo hacer :Mostrar(), no funciona con métodos
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Puertas: {numero1}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"LitrosNafta: {this.listrosNafta}");

            return sb.ToString();
        }

        //------------------------------------------------------------------------------------
        //Para sobrecargar operandos: Si quiero sobrecargar el == también tengo que hacerlo con el !=
        //ej:
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.color == v2.color;
            //Si hago return v1== v2; entro en un bucle infinito porque llamo a este mismo método infinitas veces

        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        //------------------------------------------------------------------------------------
        //Conversión:
        //1)Implícita:
        public static implicit operator string(Vehiculo v1)
        {
            return v1.color; //color es un string
        }
        //2)Explícita:
        public static explicit operator int(Vehiculo v1)
        {
            return v1.listrosNafta;
        }

        //implícito: no hay pérdida de información
        /*
        //conversion implícita: EN EL MAIN:
        //conversion implícita: 
          string color;
        //conversion explícita: 
          int ln;
        color = v1;//por atrás hay una sobrecarga implícita
        //conversión explícita:
        ln = (int)v1;*/
        //------------------------------------------------------------------------------------
    }
}
