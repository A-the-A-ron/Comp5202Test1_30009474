using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will expand a basic quadratic equation.");
            Console.WriteLine($" \t ( x + n ) ( x + m)");

            Console.WriteLine();
            Console.WriteLine("LOOKING AT THE ABOVE BRACKETS...");
            Console.WriteLine();
            Console.WriteLine("Enter a +ive or -ve value for n");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a +ive or -ve value for m");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine();
            string b;
            string c;
            Console.WriteLine();
            if (n + m < 0)
            {
                 b = $"{n + m}X ";
            }
            else
            {
                 b = $"+{n + m}X ";
            }
            if (n * m < 0)
            {
                 c = $"{n * m}";
            }
            else
            {
                c = $"+{n * m}";
            }
            Console.WriteLine($"That in Standard form is: x^2 {b}{c}");
            Console.WriteLine("press any key to exit");
            Console.ReadKey();



        }
    }
}
