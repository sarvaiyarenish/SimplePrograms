using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            int a = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }

                Console.WriteLine();
            }
        }
    }
}
