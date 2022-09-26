namespace Vistas
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = this.txtNombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show($"Hola {nombre}", "Bienvenido", MessageBoxButtons.OKCancel);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;
            //esta función "button2_Click" pertenece al form1
            //Como yo quiero saludar desde otro form CREO una variable que es del tipo
            //(o de la clase) del segundo form, llamada frmSaludar
            FrmSaludar frmSaludar = new FrmSaludar(nombre);//Saludamos desde el otro form
            if(frmSaludar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usted acepta su nombre");
            }
            else
            {
                MessageBox.Show("No le gusta su nombre");
            }
        }
    }
}