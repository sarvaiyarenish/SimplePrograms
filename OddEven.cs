using System;

namespace SimplePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string str;

            Console.Write("Enter Number : ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} Number is Even");
            }
            else
            {
                Console.WriteLine($"{x} Number is Odd");
            }

            Console.Read();
        }
    }
}
