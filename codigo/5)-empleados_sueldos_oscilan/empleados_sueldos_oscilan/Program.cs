
namespace empleados_sueldos_oscilan
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Cantidad de empleados a evaluar sueldo: ");
            int workersCount = int.Parse(Console.ReadLine());

            // con esta variable se contabilizan los que tienen 
            // un sueldo que oscile entre 100 y 300
            int osci = 0;

            int moreOf300 = 0;

            float totalMoney = 0;

            for (int i = 0; i < workersCount; i++)
            {
                Console.Write("Ingrese el sueldo del empleado {0}: $", (i + 1));
                float sueldo = float.Parse(Console.ReadLine());

                if (sueldo > 100 && sueldo < 300) osci++;
                if (sueldo > 300) moreOf300++;

                totalMoney += sueldo;
            }
            
            Console.WriteLine("Empleados que cobran entre $100 y $300: {0} \n" +
                              "Empleados que cobran mas de $300: {1} \n" +
                              "Importe total en sueldos: ${2}", osci, moreOf300, totalMoney );
            
            
        }
    }
}