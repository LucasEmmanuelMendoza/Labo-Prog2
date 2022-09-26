namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Herencia: Se hereda todo excepto los constructores
            //Una clase derivada nunca puede ser más accesible que la clase padre

            Perro p1 = new Perro("Juan", 3, "Masculino");
            Perro deRaza = new Perro("Carlos", 4, "Masculino", "Boxer");
            
            //Mascota mascota = new Mascota("Mascota", "Femenino", 8);
            //Como mascota es abstract no puedo declarar algo del tipo mascota

            Gato g1 = new Gato("Michi", 5, "Femenino");
            Console.WriteLine(p1.Ladrar());

            /* Sealed class: Clase de la que no se puede derivar*/
            Cachorro chicho = new Cachorro("chicho",6, "Masculino");
            /* Chicho heredó de perro, el cual hereda de Mascota, o sea chicho hereda de mascota*/ 
            chicho.Ladrar();

            //mascota.Saludar();

            p1.Ladrar();
            deRaza.Ladrar();

            Console.WriteLine(chicho.Equals(p1));
        }
    }
}