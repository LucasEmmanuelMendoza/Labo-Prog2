using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEJA02
{
    internal class Mascota
    {
        private string especie;
        private string nombre;
        private int[] fechaNacimiento = new int[3];
        private string[] vacunas = new string[10];

        public Mascota()
        {
            this.especie = "Sin especie";
            this.nombre = "Sin nombre";
            
            for(int i=0; i<3; i++)
            {
                this.fechaNacimiento[i] = 0;
            }

            for(int j=0; j<10; j++)
            {
                this.vacunas[j] = "Sin vacuna";
            }
        }

        public Mascota (string especie, string nombre, int[] fechaNacimiento, string[] vacunas)
        {
            this.especie = especie;
            this.nombre = nombre;

            for(int i=0; i<fechaNacimiento.Length; i++)
            {
                this.fechaNacimiento[i] = fechaNacimiento[i];
            }

            for(int j=0; j<vacunas.Length; j++)
            {
                this.vacunas[j] = vacunas[j];
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.nombre} | Especie: {this.especie} | Fecha de nacimiento:{this.fechaNacimiento[0]}{this.fechaNacimiento[1]}{this.fechaNacimiento[2]}");
            sb.AppendLine("Vacunas: ");
            {
                for(int i=0; i<vacunas.Length; i++)
                {
                    if (this.vacunas[i] != "Sin vacuna")
                    {
                        sb.Append($"{this.vacunas[i]}");
                    }
                }
            }

            return sb.ToString();
        }



    }
}
