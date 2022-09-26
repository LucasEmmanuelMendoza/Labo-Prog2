namespace Ej03Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEntero = 25;
            int numeroBinario = 11001;
            string retorno;
            int retornoDecimal;

            retorno = Conversor.ConvertirDecimalABinario(numEntero);
            retornoDecimal = Conversor.ConvertirBinarioADecimal(numeroBinario);
            Console.WriteLine($"Retorno decimal a binario: {retorno}");
            Console.WriteLine($"Retorno binario a decimal: {retornoDecimal}");
        }
    }
}