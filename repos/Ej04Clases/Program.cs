/* Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida 
sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/

namespace Ej04Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float retornoOperacion;
            float primerOperando;
            float segundoOperando;
            char operacion;

            int seguir=1;

            while(seguir == 1)
            {
                Console.WriteLine("Ingrese el primer operando: ");
                primerOperando = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo operando: ");
                segundoOperando = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operación que desea realizar: +, -, * o /");
                operacion = char.Parse(Console.ReadLine());

                retornoOperacion = Calculadora.Calcular(primerOperando, segundoOperando, operacion);

                Console.WriteLine("El resultado de la operacion es: {0}", retornoOperacion);

                Console.WriteLine("Desea seguir calculando? 1(si) - 0(no)");
                seguir = int.Parse(Console.ReadLine());
            }

        }
    }
}