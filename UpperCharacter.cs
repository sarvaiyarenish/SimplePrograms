using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class UpperCharacter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name:");
            string name = Console.ReadLine();
            string upppername = name.ToUpper();
            Console.WriteLine("UpperCharcter Name is:"+ upppername);
        }
    }
}
