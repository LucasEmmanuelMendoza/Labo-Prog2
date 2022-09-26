using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmSaludar : Form
    {
     
        public FrmSaludar()
        {
            InitializeComponent();
        }

        public FrmSaludar(string nombre) : this()
        {
            this.label1.Text = nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {   //Creo una variable string
            //Luego de elegir una opción del combobox, la guardo en esa variable
            //Si aprieto Aceptar, entro a esta función y muestro en una messageBox lo que quiero

            //DialogResult = DialogResult.OK;
            string equipo;
            equipo = this.cboEquipo.Text;
            MessageBox.Show("Usted es hincha de" +  equipo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
