using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 (long)Math.Pow(value, power)
*/

namespace Ejercicio01
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            do{
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                if(numero <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                
            }while(numero <= 0);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.Write("El cuadrado de {0} es {1} y el cubo es {2}", numero, cuadrado, cubo);

        }
    }
}
