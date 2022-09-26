namespace POOEJA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor[] conductores = new Conductor[3];
            float[] kmRecorridos = new float[7];
            string nombre;
            float sumaKm;
            float maxKm=0;

            for(int i=0; i<conductores.Length; i++)
            {
                sumaKm = 0;

                conductores[i] = new Conductor();

                Console.WriteLine("Ingrese el nombre del conductor: ");
                nombre = Console.ReadLine();

                for(int j=0; j<7; j++)
                {
                    Console.WriteLine("Ingrese los km recorridos el día {0}", j+1);
                    kmRecorridos[j] = float.Parse(Console.ReadLine());

                    sumaKm += kmRecorridos[j];
                }

                conductores[i] = new Conductor(nombre, kmRecorridos);

                if (i == 0)
                {
                    maxKm= sumaKm;
                }
                else
                {
                    if(sumaKm > maxKm)
                    {
                        maxKm = sumaKm;
                    }
                }


            }



        }
    }
}