namespace WinFormsC03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDecimal objDec = int.Parse(textBox2.Text);

            textBox4.Text = Conversor.ConvertirDecimalABinario((int)objDec);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroBinario objBin = textBox1.Text;

            textBox3.Text = Conversor.ConvertirBinarioADecimal(int.Parse(objBin.GetNum())).ToString();
        }
    }
}