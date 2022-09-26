namespace I02NumLocos2Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numeros = new ();
            List<double> numeros2 = new ();

            numeros = Ordenar.CargarNumeros(numeros, 20);
            numeros2 = numeros;

            foreach (double numero in numeros)
            {
                Console.WriteLine (numero);
            }
            Console.WriteLine("Positivos ascendentes: ");
            numeros = Ordenar.OrdenarPositivos(numeros);

            foreach (double numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Negativos descendentes: ");

            numeros2 = Ordenar.OrdenarNegativos(numeros2);

            foreach (double numero in numeros2)
            {
                if(numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}