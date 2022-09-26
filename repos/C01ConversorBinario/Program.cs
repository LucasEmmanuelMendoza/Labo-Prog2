namespace C01ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversión implícita
            NumeroBinario objBinario = "1110";
            NumeroDecimal objDecimal = 9;
            double sumaDec;
            string sumaBin;
            Console.WriteLine("objBin:");
            Console.WriteLine(objBinario.GetNum());
            Console.WriteLine("objDec:");
            Console.WriteLine(objDecimal.GetNum());

            //conversión explícita
            string binario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

            Console.WriteLine("Bin:");
            Console.WriteLine(binario);
            Console.WriteLine("Dec:");
            Console.WriteLine(numeroDecimal);

            sumaDec =  objDecimal + objBinario;
            sumaBin = objBinario + objDecimal;

            Console.WriteLine("SumaDec:");
            Console.WriteLine(sumaDec);
            Console.WriteLine("SumaBin:");
            Console.WriteLine(sumaBin);
        }
    }
}