using System.Diagnostics;

namespace Ej01Clases
{/*Pedir al usuario que ingrese 10 números enteros. 
  * Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100
  Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            bool retorno;
            int minimo = 0, maximo = 0;
            float promedio;
            int contador = 0;
            int suma = 0;
            bool flagPrimerIngreso=true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número entre -100 y 100: ");
                numero = int.Parse(Console.ReadLine());

                retorno = Validador.Validar(numero, -100, 100);

                if (retorno == true)
                {
                    contador++;

                    if (flagPrimerIngreso == true)
                    {
                        maximo = numero;
                        minimo = numero;
                        flagPrimerIngreso = false;
                    }
                    else
                    {
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                        else
                        {
                            if (numero < minimo)
                            {
                                minimo = numero;
                            }
                        }
                    }

                    suma += numero;
                }
            }
            promedio = suma / contador;

            Console.WriteLine("El mínimo es {0}\nEl máximo es {1}\nEl promedio es {2}", minimo, maximo, promedio);
        }
    }
}