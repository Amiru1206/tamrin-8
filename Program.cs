namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz en ur num");
            int x =  int.Parse(Console.ReadLine());
            int y = Fibo(x);
            if (y == 4)
                Console.WriteLine("eror");
            else
                Console.WriteLine(y);

            Console.ReadKey();
        }
        static int Fibo(int x)
        {
            if (x == 1)
                return 0;
            else if (x == 2)
                return 1;
            else if (x >= 3)
                return Fibo(x - 1) + Fibo(x - 2);
            else
                return 4;
        }
    }
}