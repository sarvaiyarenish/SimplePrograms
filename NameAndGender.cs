using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class NameAndGender
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Gender(M or F):");
            string genderInput = Console.ReadLine();

            if (string.IsNullOrEmpty(genderInput) || genderInput.Length != 1)
            {
                Console.WriteLine("Inavalid Gender Please enter (Male First letter) M Or (Female First Letter) F");
                return;
            }

                char gender = char.ToUpper(genderInput[0]);

                string prefix = "";

                if (gender == 'M')
                {
                    prefix = "Mr.";
                }
                else if (gender == 'F')
                {
                    prefix = "Mrs.";
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Gender M Or F");
                    return ;
                }

                Console.WriteLine(prefix + " " + name);
            
        }
    }
}
