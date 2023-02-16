
namespace promedio_10_valores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float rawProm = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ".- ingresa un valor: ");
                rawProm += float.Parse(Console.ReadLine());
            }

            Console.WriteLine("El promedio es: {0}", (rawProm / 10));
            
        }
    }
}