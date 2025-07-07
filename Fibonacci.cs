using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1,n3 = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.Write(n3 + " ");
                n3 = n1 + n2;
                
                n1 = n2;
                n2 = n3;
                n3 = n1;
            }
        }
    }
}
