using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaisoFiscal
{
    internal class Cliente
    {
        private string _aliasParaIncognito; 
        private string _nombre;
        private Enumerados.eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre= "NN";
            this._tipoDeCliente = Enumerados.eTipoCliente.SinTipo;
        }

        public Cliente(Enumerados.eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(Enumerados.eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            var rand = new Random();
            string auxAlias;
            auxAlias = rand.Next(1000, 9999).ToString();

            this._aliasParaIncognito = string.Concat(auxAlias, this._tipoDeCliente);
        }

        public string GetAlias()
        {
            if(this._aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
            }

            return this._aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {this._nombre}");
            sb.Append($"Alias: {GetAlias()}");
            sb.Append($"Tipo de cliente: {this._tipoDeCliente}");

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente uncliente)
        {
            string retorno = "Error";

            if(uncliente != null)
            {
                retorno = uncliente.RetornarDatos();
            }

            return retorno;
        }
    }
}
