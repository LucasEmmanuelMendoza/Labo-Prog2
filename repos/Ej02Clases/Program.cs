namespace Ej02Clases
{/* Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
 "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

*/
    internal class Program
    {
        static void Main(string[] args)
        {
            char rta;
            int suma = 0;
            int numero;
            bool seguir = true;

            while (seguir)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                suma += numero;

                Console.WriteLine("¿Desea continuar ingresando?(S/N)");
                rta = char.Parse(Console.ReadLine());
                rta = char.ToUpper(rta);
                seguir = Validador.ValidarRespuesta(rta);
            }

            Console.WriteLine("La suma es: {0}", suma);
        }
    }
}