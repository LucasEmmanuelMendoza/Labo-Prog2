using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEJ05
{
    internal class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            int retorno;

            retorno = this.x;

            return retorno;
        }        
        public int GetY()
        {
            int retorno;

            retorno = this.y;

            return retorno;
        }

        public Punto (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
