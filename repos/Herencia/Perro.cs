using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Perro : Mascota
    {//Así decimos que perro heredó de mascota, es decir, todo lo que tiene Mascota ahora lo tiene perro

        private string raza;

        //Esto significa que nombre reemplaza el atributo nombre de Mascota
        public Perro(string nombre, int patas, string sexo) : base(nombre, sexo, patas)
        {

        }
        
        //para tener un perro tengo que tener como mínimo nombre sexo y patas, es decir, los atributos
        //de la clase heredada
        public Perro(string nombre, int patas, string sexo, string raza) : this(nombre, patas, sexo) 
        {
            this.raza = raza;
        }
       public string Ladrar()
        {
            return this.nombre + "GUAU";
        }
    }

    public class Cachorro : Perro
    {
        public Cachorro(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {

        }
    }
}
