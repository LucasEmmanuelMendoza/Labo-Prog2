using System.Text;

namespace WinFormsI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string equipo;
            equipo = this.cboEquipo.Text;
            MessageBox.Show("Usted es hincha de" +  equipo);
            this.comboBox1.Text = "Inglés II";
            this.comboBox1 = new ComboBox();*/
            this.comboBox1.Text = "Inglés II";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string materia;
            nombre = textBox1.Text;
            apellido = textBox2.Text;
            materia = this.comboBox1.Text;

            if (Validar())
            {
                Saludo frmSaludo = new Saludo($"Soy {nombre} {apellido} y mi materia favorita es {materia}", "¡Hola, Windows Forms!");
                frmSaludo.ShowDialog();
            }
        }
        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}