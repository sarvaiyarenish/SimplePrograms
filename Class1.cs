using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 4, 6, 8, 9, 10 };
            Console.WriteLine("Max Number is:"+ a.Max());
            Console.WriteLine("Min Number is:" + a.Min());

            var reverse = a.Reverse();
            foreach(int i in reverse)
            {
                Console.Write(i + " ");
            }
        }
    }
}
