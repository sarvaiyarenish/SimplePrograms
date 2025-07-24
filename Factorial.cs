using System;  // Includes the System namespace for basic input/output operations

namespace SimplePrograms  // Declares a namespace for the program
{
    internal class Factorial  // Declares a class named Program
    {
        public static void Main(string[] args)  // Main method - entry point of the program
        {
            int n, fact = 1;  // Declare integer variables n (for input number) and fact initialized to 1 (for factorial)

            Console.Write("Enter Number : ");  // user to enter a number

            string str = Console.ReadLine();  // Read user input as a string

            n = Convert.ToInt32(str);  // Convert the input string to an integer

            for (int i = 1; i <= n; i++)  // Loop from 1 to n
            {
                fact = fact * i;  // Multiply fact by i in each iteration to calculate factorial
            }

            Console.WriteLine("Factorial : {0}", fact);  // Display the result using placeholder formatting

            Console.Read();  // Wait for user to press a key before closing the console
        }
    }
}
