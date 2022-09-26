using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C01EstadisticaDepo
{
    internal class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            return this.promedioGoles;
        }

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "Sin nombre";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int goles, int totalPartidos) :this(dni, nombre)
        {
            this.totalGoles = goles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Dni: {this.dni}");
            sb.Append($"Nombre: {this.nombre}");
            sb.Append($"Partidos jugados: {this.partidosJugados}");
            sb.Append($"Total goles: {this.totalGoles}");
            sb.Append($"Promedio goles: {this.promedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
