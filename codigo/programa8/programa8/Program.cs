internal class Program
{
    private static void Main(string[] args)
    {
        int total1 = 0, total2 = 0;
        int[] lista1 = new int[15];
        int[] lista2 = new int[15];

        for (int i = 0; i <= 14; i++)
        {
            Console.WriteLine("Ingresa el valor {0} de la primera lista", i + 1);
            lista1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i <= 14; i++)
        {
            Console.WriteLine("Ingresa el valor {0} de la segunda lista", i + 1);
            lista2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= 14; i++)
        {
            total1 += lista1[i];
            total2 += lista2[i];
        }

        if (total1 > total2)
        {
            Console.WriteLine("La lista 1 es mayor");
        }
        else if (total2 > total1)
        {
            Console.WriteLine("La lista 2 es mayor");
        }
        else if (total1 == total2) 
        {
            Console.WriteLine("Las dos listas son iguales");
        }
    }
}