using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaisoFiscal
{
    internal class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private Enumerados.eParaisosFiscales _lugar;
        public int cantidadDeCuentas;
        public DateTime fechaInicioActividades;

        private ParaisoFiscal()
        {
            _listadoCuentas = new List<CuentaOffShore>();
            this.cantidadDeCuentas = 0;
            this.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal(Enumerados.eParaisosFiscales lugar) :this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
            
        }

    }
}
