using System.Runtime.CompilerServices;

namespace Clase01_Ej3
{/* Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
De lo contrario, cerrar la consola.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            string strNum;
            int num;
            bool esNum;
            int contador;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                strNum = Console.ReadLine();
                esNum = int.TryParse(strNum,out num);
            }while(string.Compare(strNum, "Salir")!=0 && esNum == false);

            if(string.Compare(strNum, "Salir") ==0)
            {
                //salir del programa
            }

            for(int i=2; i<num; i++)
            {         
                contador = 0;
                //recorro con un for desde el 2 hasta el número mismo sin incluirlo y si hay algún divisor entonces no es primo
                for(int j=i-1; j>1; j--)
                {
                    if(i % j == 0)
                    {
                        contador += 1;
                    }
                }
                if(contador < 1)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}