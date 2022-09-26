namespace POOEj02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona persona = new Persona();
            Persona[] personas = new Persona[3];

            int dia;
            int mes;
            int año;

            int[] fechaActual = { 3, 9, 2022 };
            int[] fechaNacimiento = new int[3];
            int[] fechaNacAux = new int[3];
            string strRetorno;
            int retornoCompare;

           for(int i=0; i<3; i++)
            {
                personas[i] = new Persona();

                Console.WriteLine("Ingrese la persona número {0}", i + 1);
                Console.WriteLine("Nombre: ");
                personas[i].SetNombre(Console.ReadLine());

                Console.WriteLine("Dni: ");
                personas[i].SetDni(int.Parse(Console.ReadLine()));

                Console.WriteLine("Fecha de nacimiento:");
                Console.WriteLine("Día:");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Mes:");
                mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Año:");
                año = int.Parse(Console.ReadLine());

                fechaNacimiento[0] = dia;
                fechaNacimiento[1] = mes;
                fechaNacimiento[2] = año;

            personas[i].SetFechaNacimiento(fechaNacimiento);

           }

            Console.WriteLine("Son mayores de edad:");
            for (int j=0; j<3; j++)
            {
                personas[j].GetFechaNacimiento(fechaNacAux);

                strRetorno = personas[j].EsMayorDeEdad(fechaNacAux, fechaActual);
            
                retornoCompare = String.Compare("Es mayor de edad", strRetorno);

             if (retornoCompare == 0)
                 {
                  Console.WriteLine(personas[j].Mostrar());
                } 
             }
        }
    }
}
    