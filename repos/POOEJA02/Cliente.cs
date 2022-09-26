using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEJA02
{
    internal class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private long telefono;
        private Mascota[] mascota = new Mascota[5];

        public Cliente()
        {
            this.domicilio = "Sin domicilio";
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
            this.telefono = 0;

            for(int i = 0; i < mascota.Length; i++)
            {
                this.mascota[i] = new Mascota();
            }
        }

        public Cliente(string domicilio, string nombre, string apellido, long telefono, Mascota[] mascota)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            
            for(int i=0; i<mascota.Length; i++)
            {
                this.mascota[i] = mascota[i];
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this.nombre} | Apellido: {this.apellido} | Domicilio: {this.domicilio} | Teléfono: {this.telefono}");
            sb.Append("Mascotas:");
            for(int i=0; i<mascota.Length; i++)
            {
                sb.Append(mascota[i].Mostrar());
            }

            return sb.ToString();
        }


    }
}
