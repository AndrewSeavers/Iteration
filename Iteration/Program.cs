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
            Console.ReadLine();
        }
    }
}
