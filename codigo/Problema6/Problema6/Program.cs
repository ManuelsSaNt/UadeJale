internal class Program
{
    private static void Main(string[] args)
    {
        int numeros;
        Console.WriteLine("Pulsa una tecla para iniciar");
        Console.ReadKey();
        int x = 1;

        while (x <= 25)
        {
            numeros = x * 11;
            Console.WriteLine(numeros);
            numeros= 0;
            x++;
        }

    }
}