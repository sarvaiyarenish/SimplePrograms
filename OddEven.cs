using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
        }
    }
}
