internal class Program
{
    private static void Main(string[] args)
    {
        int cantidad;
        int x = 1;
        int contador = 0;
        float longitud;
        Console.WriteLine("Ingresa la cantidad de piezas a revisar");
        cantidad = int.Parse(Console.ReadLine());
  
        while (x < cantidad+1) 
        {
            Console.WriteLine("Ingresa la longitud de la pieza {0}", x);
            longitud = float.Parse(Console.ReadLine());

            if (longitud >= 1.20 && longitud <= 1.30)
            {
                contador++;
            }
            x++;
        }

        Console.WriteLine("El total hay {0} piezas aptas en el lote", contador);
    }
}