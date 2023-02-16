internal class Program
{
    private static void Main(string[] args)
    {
        int numero1, numero2;
        int opcion;
        do
        {
            Console.WriteLine("¿Qué accción quieres realizar?");
            Console.WriteLine("1.Sumar\n" + "2.Resta\n" + "3.Multipliación\n" + "4.Division\n" + "5.Salir");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 5)
            {
                Environment.Exit(0);
            }

            if (opcion >= 1 && opcion <= 4)
            {
                Console.WriteLine("\nIngresa el valor del numero 1");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngresa el valor del numero 2");
                numero2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("El resultado de la suma es: ");
                        Console.WriteLine(numero1 + numero2);
                        break;
                    case 2:
                        Console.Write("El resultado de la resta es: ");
                        Console.WriteLine(numero1 - numero2);
                        break;
                    case 3:
                        Console.Write("El resultado de la multiplicacion es: ");
                        Console.WriteLine(numero1 * numero2);
                        break;
                    case 4:
                        Console.Write("El resultado de la division es: ");
                        Console.WriteLine(numero1 / numero2);
                        break;
                }

                Console.WriteLine("\nPulsa una tecla para reiniciar");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nLa opcion ingresada no es valida");
                Console.ReadKey();
                Console.Clear();
            }
        } while (opcion != 5);

    }
}
