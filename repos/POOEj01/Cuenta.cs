using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEj01
{
    public class Cuenta
    {
        private string  titular;
        private float  cantidad;

        //constructor
        public Cuenta()
        {            
            this.titular = "Sin titular";
            this.cantidad = 0;
        }

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return "Titular:" + GetTitular() + "\nCantidad:" + GetCantidad();
        }

        public void Ingresar(float montoIngresado)
        {
            if (montoIngresado > 0)
            {
                this.cantidad += montoIngresado;
            }
        }

        public void Retirar(float montoARetirar)
        {
            if(montoARetirar > 0)
            {
                this.cantidad -= montoARetirar;
            }
        }

    }
}
