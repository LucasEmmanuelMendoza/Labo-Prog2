using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C01EstadisticaDepo
{
    internal class Equipo
    {
        private short cantidadDeJugadores;
        List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            this.nombre = "Sin nombre";
            this.cantidadDeJugadores = 0;
        }
        
         public Equipo(short cantidad, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno;
            retorno = false;

            if( e.jugadores.Count < e.cantidadDeJugadores && EstaEnElEquipo(e, j) == false)
            {
                e.jugadores.Add(j);
            }
            return retorno;
        }

        public static bool EstaEnElEquipo(Equipo e, Jugador j)
        {
            bool retorno;

            retorno = false;

            foreach(Jugador j1 in e.jugadores)
            {
                if(j == j1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
