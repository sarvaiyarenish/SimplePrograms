using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class SumOfSeries
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Terms: ");
            int t = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            int b = n, a = n;

            for (int i = 1; i < t; i++)
            {
                n = b + (n * 10);
                a = a + n;
                Console.WriteLine(n);
            }
            Console.WriteLine("Sum of series is:"+a);
        }
    }
}
