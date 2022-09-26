namespace I01NumLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[20];
            double[] retorno = new double[20];

            numeros = ClaseRandom.GenerarNums();
            Console.WriteLine("Array original:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("---------------------------------");

            retorno = ClaseRandom.OrdenarPositivos(numeros);

            Console.WriteLine("Positivos ordenados de manera decreciente:");
            for(int i = 0; i < retorno.Length; i++)
            {
                if (retorno[i] != 0)
                {
                    Console.WriteLine(retorno[i]);
                }
            }

            retorno = ClaseRandom.OrdenarNegativos(numeros);
            Console.WriteLine("Negativos ordenados de manera creciente:");
            for (int i = 0; i < retorno.Length; i++)
            {
                if (retorno[i] != 0)
                {
                    Console.WriteLine(retorno[i]);
                }
            }
        }
    }
}