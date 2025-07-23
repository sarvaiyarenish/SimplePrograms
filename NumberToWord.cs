using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class NumberToWord
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number:");
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int r, sum = 0;
            while(num > 0)
            {
                r = num % 10;
                sum = r + (sum * 10);
                num = num / 10;
            }

            num = sum;

            while (num > 0)
            {
                r = num % 10;
                switch (r)
                {
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                    case 0:
                        Console.Write("Zero ");
                        break;
                }
                num = num / 10;
            }
        }
    }
}
