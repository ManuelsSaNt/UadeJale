
namespace multiplos_8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = 1;
            string fnlTxt = "";
            while (x < 500)
            {
                if (x % 8 == 0)
                {
                    fnlTxt += x + "-";
                }
                x++;
            }
            Console.WriteLine(fnlTxt[..^1]);
        }
    }
}