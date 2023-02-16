// See https://aka.ms/new-console-template for more information

namespace countPares
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Cantidad de numeros a ingresar: ");
            int nums = int.Parse(Console.ReadLine());

            int evens = 0;
            int notEvens = 0;

            for (int i = 0; i < nums; i++)
            {
                Console.Write((i + 1) + ".- Ingresa un numero: ");
                int inp = int.Parse(Console.ReadLine());
                if (inp % 2 == 0)
                {
                    evens++;
                }
                else
                {
                    notEvens++;
                }
            }
            Console.WriteLine("Total de numeros pares: {0} \n" +
                              "Total de numeros impares: {1}", evens, notEvens);
        }
    }
}