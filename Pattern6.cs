using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 17; i += 2)
            {
                int k = (i > 9) ? 18 - i : i;
                for (int j = 9; j > k; j -= 2)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
