using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Num1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num2:");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Sum is:" + c);

        }
    }
}
