using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // Check if the number is even or odd 
            
            
            string evenodd = (num % 2 == 0) ? "even" : "odd";
            Console.WriteLine("The number is " + evenodd );
        }
    }
    
}
