namespace WinFormsI02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresante nuevoIngresante = new Ingresante();
            string nombre = textBox1.Text;
            string direccion = textBox2.Text;
            string edad = numericUpDown1.Value.ToString();
            string pais = países.Text;
            string genero = null;
            string[] cursos = new string[3];

            if (radioButton1.Checked)
            {
                genero = radioButton1.Text;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    genero = radioButton2.Text;
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        genero = radioButton3.Text;
                    }
                }
            }

            //cursos[0] = checkBox1.Checked;
            //cursos[1] = checkBox2.Text;
            //cursos[2] = checkBox3.Text;

            if (checkBox1.Checked)
            {
                cursos[0] = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                cursos[1] = checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                cursos[2] = checkBox3.Text;
            }

             nuevoIngresante = new Ingresante(cursos, direccion, int.Parse(edad), genero, nombre, pais);

            MessageBox.Show(nuevoIngresante.Mostrar());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}