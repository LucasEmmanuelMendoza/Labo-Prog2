namespace Clase01_Ej1
{
    /*Ingresar 5 números por consola, guardándolos en una variable escalar. 
     * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; 
            int min = 0;
            int max = 0;

            string numStr;
            int suma;
            float promedio;

            suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número: ");

                numStr = Console.ReadLine();

                numero = int.Parse(numStr);

                if (i == 0)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if(numero > max)
                    {
                        max = numero;
                    }
                    else
                    {
                        if (numero < min)
                        {
                            min = numero;
                        }
                    }
                }

                suma = suma + numero;
            }

            promedio = (float)suma / 5;

            Console.WriteLine("El máximo es: {0}\nEl Mínimo es: {1}\nEl promedio es: {2}", max, min, promedio);
        }
    }
}