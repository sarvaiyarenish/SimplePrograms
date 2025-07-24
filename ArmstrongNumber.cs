using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstCodeC_
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            int r, sum = 0, a = n;

            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (a == sum)
            {
                Console.WriteLine($"{a} is Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{a} is Not an Armstrong Number");
            }
        }
    }
}