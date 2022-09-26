/*Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

La clase Estudiante:

Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
El método privado CalcularPromedio retornará el promedio de las dos notas.
El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre y 
cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos */
namespace POOEJ03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[3];
            string apellido;
            string nombre;
            string legajo;
            int notaPrimerParcial;
            int notaSegundoParcial;
            string retornoMostrar;

            for(int i = 0; i<3; i++)
            {
                estudiantes[i] = new Estudiante();

                Console.WriteLine($"Estudiante número {i + 1}:");
                Console.WriteLine("Ingrese apellido: ");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese legajo: ");
                legajo = Console.ReadLine();

                estudiantes[i] = new Estudiante(apellido, nombre, legajo);

                Console.WriteLine("Ingrese nota del primer parcial: ");
                notaPrimerParcial = int.Parse(Console.ReadLine());
                estudiantes[i].SetNotaPrimerParcial(notaPrimerParcial);

                Console.WriteLine("Ingrese nota del segundo parcial: ");
                notaSegundoParcial = int.Parse(Console.ReadLine());
                estudiantes[i].SetNotaSegundoParcial(notaSegundoParcial);
            }

            for (int i = 0; i < 3; i++)
            {
                retornoMostrar = estudiantes[i].Mostrar();
                Console.WriteLine(retornoMostrar);
            }
        }
    }
}