using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsI02
{
    internal class Ingresante
    {
        private string[] cursos = new string[3];
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante()
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                this.cursos[i] = "Sin curso";
            }
            this.direccion = "Sin dirección";
            this.edad = 0;
            this.genero = "Sin género";
            this.nombre = "Sin nombre";
            this.pais = "Sin país";
        }
        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            for(int i = 0; i < cursos.Length; i++)
            {
                this.cursos[i] = cursos[i];
            }
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.nombre}");
            sb.Append($"\nDirección: {this.direccion}");
            sb.Append($"\nEdad: {this.edad}");
            sb.Append($"\nGénero:: {this.genero}");
            sb.Append($"\nPaís: {this.pais}");
            sb.Append($"\nCursos:");
            for(int i=0; i<this.cursos.Length; i++)
            {
                sb.Append($"\n\t{this.cursos[i]}");
            }

            return sb.ToString();
        }
    }
}
