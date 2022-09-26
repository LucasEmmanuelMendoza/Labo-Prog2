using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEj02
{
    public class Persona
    {
        private string nombre;
        private int[] fechaDeNacimiento = new int[3];
        private int dni;

        public Persona()
        {
            nombre = "Sin nombre";

            for (int i = 0; i < 3; i++)
            {
                fechaDeNacimiento[i] = 0;
            }

            dni = 0;
        }

        public void SetNombre(string name)
        {
            this.nombre = name;
        }

        public void SetFechaNacimiento(int[] fechaNac)
        {
            for (int i = 0; i < 3; i++)
            {
                this.fechaDeNacimiento[i] = fechaNac[i];
            }
        }

        public void SetDni(int newDni)
        {
            this.dni = newDni;
        }

        public string GetNombre()
        {
            string retorno;

            retorno = this.nombre;

            return retorno;
        }

        public int GetDni()
        {
            int retorno;

            retorno = this.dni;

            return retorno;
        }

        public void GetFechaNacimiento(int[] fechaNac)
        { 
            for (int i = 0; i < 3; i++)
            {
                fechaNac[i] = this.fechaDeNacimiento[i];
            }
        }

        private int CalcularEdad(int[] fechaNac, int[] fechaActual)
        {
            int retorno;

            retorno = fechaActual[2] - fechaNac[2] - 1;

            if (fechaNac[1] >= fechaActual[1] && fechaNac[0] >= fechaActual[0])
            {
                retorno = fechaActual[2] - fechaNac[2];
            }

            return retorno;
        }

        public string Mostrar(/*string name, int dni, int[] fechaNac*/)
        {
            /*
            StringBuilder sb = new StringBuilder();*/
            string retorno;
            int[] fechaNac = new int[3];

            GetFechaNacimiento(fechaNac);

            retorno = "Nombre: " + GetNombre() +"\nDni: " + GetDni() + "\nFecha de Nacimiento: " + $"{fechaNac[0]}, {fechaNac[1]}, {fechaNac[2]}";

            return retorno;

            //sb.Append($"{GetNombre} {GetDni} {fechaNac[0]}{fechaNac[1]}{fechaNac[2]}");
            //sb.Append("LA puta madre que te parió");
            //return sb.ToString(); 
        }

        public string EsMayorDeEdad(int[] fechaNac, int[] fechaActual)
        {
            string retorno;
            int edad;

            retorno = "Es mayor de edad";

            edad = CalcularEdad(fechaNac, fechaActual);

            if (edad < 18)
            {
                retorno = "es menor";
            }

            return retorno;
        }
    }
}
