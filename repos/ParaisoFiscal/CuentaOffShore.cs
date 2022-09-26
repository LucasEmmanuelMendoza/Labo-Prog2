using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaisoFiscal
{
    internal class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double saldo;

        public Cliente Dueño
        {
            get { return this._dueño;}
        }

        public double Saldo
        {
            get { return this.saldo;}
            set { this.saldo = value;}
        }

        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            _dueño = dueño;
            _numeroCuenta = numero;
            Saldo = saldoInicial;
        }
         
       public CuentaOffShore(string nombre, Enumerados.eTipoCliente tipo, int numero, double saldoInicial) : this(new Cliente(tipo, nombre), numero, saldoInicial)
        {

        }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool retorno;

            retorno = false;

            if (cos1 is not null && cos2 is not null)//utilizar GetAlias
            {
                if (cos1._dueño.GetAlias() == cos2._dueño.GetAlias() && (int)cos1 == (int)cos2)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }

        public void MostrarCuenta()
        {
            Console.WriteLine($"Dueño: {this._dueño}");
            Console.WriteLine($"Numero de cuenta: {this._numeroCuenta}");
            Console.WriteLine($"Saldo: {this.saldo}");
        }
    }
}
