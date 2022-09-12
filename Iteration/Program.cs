using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string userIn = "";
            int index = 0;

            // Repeat 50 times
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Number {i+1} of the list");
            }
            
            // Repeat until the user says "yes"
            while (userIn != "yes")
            {
                index++;
                Console.WriteLine($"Number {index}");
                userIn = Console.ReadLine();
            }

            // Repeats from 1 to 50
            for(int i = 1; i <= 50; i++)
            {
                // say if number is odd or even
                string oddOrEven = (i % 2 == 0)? "even" : "odd";

                Console.WriteLine($"{i} is {oddOrEven}");

                // say if number is divisible by 3
                string divisibleByThree = (i % 3 == 0) ? "is" : "is not";

                Console.WriteLine($"{i} {divisibleByThree} divisible by 3");
            }

            Console.ReadLine();
        }
    }
}
