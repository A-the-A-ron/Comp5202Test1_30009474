using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "clear";
            do
            {
                Console.WriteLine("Enter a number, and I will tell you if it's even");
            
                int check = 0;
            
            
                if (!int.TryParse(Console.ReadLine(), out check))
                {

                    Console.WriteLine("This is not a number");
                    c = "woops";
                }


                else if (check % 2 == 0)
                {
                    Console.WriteLine("That number is even.");
                    c = "clear";
                }
                else
                {
                    Console.WriteLine("that number is odd.");
                    c = "clear";
                }
            } while (c == "woops");
            Console.WriteLine("press enter to close");
            Console.ReadLine();

        }
    }
}
