using System.Runtime.InteropServices;

namespace Clase01_Ej4
{/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del
número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos. */
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador;
            int contador;

            Console.WriteLine("Números perfectos: ");
            for(int i=0; i<1000; i++)
            {
                acumulador = 0;
                contador = 0;
                //Console.WriteLine("Número: {0}", i);
                for(int j=i-1; j>0; j--)
                {
                    if(i%j == 0)
                    {
                        //Console.WriteLine("Divisor: {0}", j);
                        acumulador += j;
                    }
                }
                if(acumulador == i)
                {
                    Console.WriteLine(i);
                    contador++;
                }
                if(contador == 4)
                {
                    break;
                }
            }
        }
    }
}