using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POOEJ03
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random random = new Random(0);

        //Tendrá un constructor estático que inicializará el atributo estático random.

        public Estudiante()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.legajo = "Sin legajo";
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float retorno;

            retorno = (this.notaPrimerParcial + this.notaSegundoParcial) / 2;

            return retorno;
        }

        public double CalcularNotaFinal()
        {
            double retorno = -1;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                retorno = random.Next(1, 11);
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            float promedio;
            double notaFinal;

            promedio = CalcularPromedio();
            notaFinal = CalcularNotaFinal();

            sb.Append($"{this.nombre} {this.apellido} {this.legajo}");
            sb.Append($"\nPrimer parcial: {this.notaPrimerParcial} | Segundo Parcial: {this.notaSegundoParcial}");
            sb.Append($"\nPromedio: {promedio}");
            
            if (notaFinal != -1)
            {
                sb.Append($"\nNota final: {notaFinal}");
            }
            else
            {
                sb.Append("\nAlumno desaprobado");
            }

            return sb.ToString();
        }
    }
}
