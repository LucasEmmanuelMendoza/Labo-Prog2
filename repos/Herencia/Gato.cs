using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Gato : Mascota
    {
        private int vidas;

        public Gato(string nombre, int patas, string sexo) : base (nombre, sexo, patas)
        {

        }
        public Gato(string nombre, int patas, string sexo, int vidas) : base (nombre, sexo, patas)
        {
            this.vidas = vidas;
        }

    }
}
