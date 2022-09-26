namespace Clase01_Ej2
{
    /* Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, 
     * caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un número mayor a cero: ");
            num = double.Parse(Console.ReadLine());

            while(num <= 0)
            {
                Console.WriteLine("Error. Reingresar número: ");
                num = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado de {0} es: {1}\nEl cubo de {0} es: {2}", num, cuadrado, cubo);            
        }
    }
}