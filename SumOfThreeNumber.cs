using System;

namespace SimplePrograms
{
    class SumOfThreeNumber

    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            string str;

            Console.Write("Enter Number1: ");

            str =  Console.ReadLine();

            a = Convert.ToInt32(str);
            Console.Write("Enter Number2 : ");

            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number3 : ");

            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            result = Sum(a, b, c);
            Console.WriteLine($"Sum is: {result}");

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}