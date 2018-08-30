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
            Console.WriteLine("Enter a number, and I will tell you if it's even");
            int check = int.Parse(Console.ReadLine()); 
            if (check % 2 == 0)
            {
                Console.WriteLine("That number is even.");
            }
            else
            {
                Console.WriteLine("that number is odd.");
            }
            Console.WriteLine("press enter to close");
            Console.ReadLine();
        }
    }
}
