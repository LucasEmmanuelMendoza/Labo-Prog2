using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    internal class Animal
    {
        //Atributo de un animal:
        //nombre
        //edad
        //tipo
        //Declaramos los atributos:
       
        public string nombre;
        public int edad;
        public string tipodDeAnimal;
        public static int contadorDeAnimales = 0;//al ser estático no se puede hacer this.contadorDeAnimales

        //public static contador

        static Animal()
        {
            Animal.contadorDeAnimales = 0;
        }

        //Creamos el constructor con el mismo nombre de la clase:
        public Animal(string nombre, int edad, string tipodDeAnimal)
        {
            //nombre = "Sin nombre";
            //edad = 2;
            //tipodDeAnimal = "Desconocido
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipodDeAnimal = tipodDeAnimal;
        }

        //Creamos otro constructor sin parámetros:
        //Acá vamos a asignar nuestros propios valores por default 
        public Animal()
        {
            Animal.contadorDeAnimales++;
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.tipodDeAnimal = "Desconocido";
        }

        //Métodos de un animal (Comportamiento - Acciones - Funciones):
        //hablar
        //comer
        public string Hablar()
        {
            StringBuilder sb = new StringBuilder();

            //si usamos atributo usamos el this al llamarlo, si usamos variable NO
            sb.Append("Mi nombre es ");
            sb.AppendLine(this.nombre);
            sb.Append("Tengo ");
            sb.AppendLine(this.edad.ToString());
            sb.AppendLine("años");
            sb.Append("y soy un ");
            sb.AppendLine(this.tipodDeAnimal);

            //return "Hola me llamo " + this.nombre + ", tengo " + this.edad + " años y soy un " + this.tipodDeAnimal;

            return sb.ToString();
        }
 
    }
}
