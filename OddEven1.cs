using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class OddEven1
    {
        static void Main(string[] args)
        { 
                int x;
                Console.WriteLine("Enter Number : ");
                string str = Console.ReadLine();
                x = Convert.ToInt32(str);


                if (x % 2 == 0)
                {
                    Console.WriteLine("Number is Even");


                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
                Console.Read();
        }
    }
}