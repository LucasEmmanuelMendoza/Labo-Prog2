using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public abstract class Mascota
    {
        //Clase abstracta: de esta clase derivan otras clases y las podes usar pero no quiero que me 
        //instancien mascotas porque es una clase de molde porque no quiero que la usen
        protected private string nombre;
        private string sexo;
        private int patas;

        public string Nombre //propiedad
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Mascota (string nombre, string sexo, int patas)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.patas = patas;
        }

        public string Saludar()
        {
            return $"Hola soy {this.nombre}";
        }
    }
}
