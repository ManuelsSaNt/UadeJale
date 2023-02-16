namespace conjunto_alturas
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int vueltas = 0;
            
            Console.Write("Ingresa la cantidad de regsitros a ingresar: ");
            vueltas += int.Parse(Console.ReadLine());
            
            float rawProm = 0;

            for (int i = 0; i < vueltas; i++)
            {
                Console.Write((i + 1) + ".- ingresa una Altura: ");
                rawProm += float.Parse(Console.ReadLine());
            }

            float prom = (rawProm / vueltas);
            Console.WriteLine("El promedio de Altura es: {0}", ( prom > 1 ? prom + "m" : prom + "cm"));
            
        }
    }
}