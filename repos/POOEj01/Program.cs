namespace POOEj01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta nuevaCuenta;
            string titular;
            float monto;
            int seguir=1;
            int opcion = 0;
            string retorno1;
            float montoAIngresar=0;
            float montoARetirar=0;

            Console.Write("Ingrese el titular de la cuenta: ");
            titular = Console.ReadLine();

            Console.Write("Ingrese el monto actual de la cuenta: ");
            monto = float.Parse(Console.ReadLine());

            nuevaCuenta = new Cuenta();
            nuevaCuenta = new Cuenta(titular, monto);

            while (seguir == 1)
            {
                Console.WriteLine("1)Mostrar datos de la cuenta");
                Console.WriteLine("2)Ingresar un monto a la cuenta");
                Console.WriteLine("3)Retirar un monto de la cuenta");
                
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:
                        Console.WriteLine(nuevaCuenta.Mostrar());
                        break;  

                    case 2:
                        Console.WriteLine("Ingrese el monto a ingresar en la cuenta: ");
                        montoAIngresar = float.Parse(Console.ReadLine());
                        nuevaCuenta.Ingresar(montoAIngresar);
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar de la cuenta: ");
                        montoARetirar = float.Parse(Console.ReadLine());
                        nuevaCuenta.Retirar(montoARetirar);
                        break;
                }

                Console.WriteLine("Desea continuar realizando operaciones? si=1/no=0");
                seguir = int.Parse(Console.ReadLine());
            }
        }
    }
}