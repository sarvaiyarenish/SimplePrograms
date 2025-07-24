using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class Profile
    {
        static void Main(string[] args)
        {
            string name, dob, address1, address2, city, pincode, state, country, email;


            Console.Write("Enter Name: ");
            name = Console.ReadLine();


            Console.Write("Enter DOB (dd/mm/yyyy): ");
            dob = Console.ReadLine();


            Console.Write("Enter Address Line 1: ");
            address1 = Console.ReadLine();


            Console.Write("Enter Address Line 2: ");
            address2 = Console.ReadLine();


            Console.Write("Enter City: ");
            city = Console.ReadLine();


            Console.Write("Enter Pincode: ");
            pincode = Console.ReadLine();


            Console.Write("Enter State: ");
            state = Console.ReadLine();


            Console.Write("Enter Country: ");
            country = Console.ReadLine();


            Console.Write("Enter Email: ");
            email = Console.ReadLine();


            Console.WriteLine("\n--- Profile Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Address: " + address1);
            Console.WriteLine("                 " + address2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Pincode: " + pincode);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Email: " + email);
        }
    }
}

