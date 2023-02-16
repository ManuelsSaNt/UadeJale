internal class Program
{
    private static void Main(string[] args)
    {
        int[] notas = new int[10];
        int x = 0;
        int alumnos = 0;
        int reprobados = 0;

        while (x < 10)
        {
            Console.WriteLine("Ingresa una calificacion");
            notas[x] = int.Parse(Console.ReadLine());

            if (notas[x] >= 7)
            {
                alumnos++;
            }
            else if (notas[x] < 7)
            {
                reprobados++;
            }
            x++;
        }
        Console.WriteLine("{0} Sacaron una calificacion mayor o igual a 7 y {1} alumnos sacaron menor a 7", alumnos, reprobados);        






    }
}