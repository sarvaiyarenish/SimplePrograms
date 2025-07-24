using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileNo
{
    internal class MobileNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number:");
            string mobile = Console.ReadLine();

            if(mobile.Length < 5)
            {
                Console.WriteLine("Invalid Mobile Number.Must Be Atleast 10 number");
            }
            else
            {
                string masked = mobile.Substring(0,mobile.Length - 5) + "xxxxx";
                Console.WriteLine(masked);
            }
        }
    }
}
