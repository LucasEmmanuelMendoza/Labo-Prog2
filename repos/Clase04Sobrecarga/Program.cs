namespace Clase04Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversion implícita: 
            string color;
            //conversion explícita: 
            int ln;

            Vehiculo v1 = new Vehiculo(5);

            Vehiculo v2 = new Vehiculo("assdaas", 5);

            Vehiculo v3 = new Vehiculo("asdadas", 5, "rojo");

            Vehiculo v4 = new Vehiculo("asdadas", 5, "rojo", 100);

            //conversion implícita: 
            color = v1;//por atrás hay una sobrecarga implícita
            //conversión explícita:
            ln = (int)v1;

            /* 
            v2.Color = "Rojo";

            v1.Color = v2.Color;
            */
            Console.WriteLine(v1.Mostrar());
        }
    }
}