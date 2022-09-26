namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primero creamos la variable:

            //string nombre;
            Animal animal1;
            //necesitamos instanciar la variable, reservar espacio de memoria para nuestra variable (new):
            //Usamos el constructor Animal();
            animal1 = new Animal("Pepe", 10, "Perro");
            //ahora sí lo podemos usar:

            Animal animal2;
            animal2 = new Animal("Pepe", 10, "Perro");
            //animal2 = new Animal();

            //animal1.nombre = "Pepe";
            //animal1.edad = 10;
            //animal1.tipo = "Perro";

            // animal2.edad = 5;
            //animal2.tipodDeAnimal = "Gato";

            Console.WriteLine(animal1.Hablar());
            Console.WriteLine(animal2.Hablar());
            Console.WriteLine("Cantidad de animales: " + Animal.contadorDeAnimales);

            //Animal.Hablar();

            if(animal1 == animal2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }
            //Al ser objetos de referencia, son diferentes. Al comparar, se compara la posición de memoria de animal1
            //con la posición de memoria de animal2
            
            //Si hacemos animal1 = new()...
            //           animal2 = animal1;
            //Ahora sí va a dar igual porque los dos están apuntando a la misma dirección de memoria

            //Distinto es comparar los campos
            if (animal1.nombre == animal2.nombre)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }
        }
    }
}