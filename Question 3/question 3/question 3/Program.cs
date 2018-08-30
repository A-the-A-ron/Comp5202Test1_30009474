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
            string safe = "yes";
            Console.WriteLine();
            Console.WriteLine("LOOKING AT THE ABOVE BRACKETS...");
            Console.WriteLine();
            float n = 0;
            float m = 0;
            do
            {
                Console.WriteLine("Enter a +ive or -ve value for n");
                
                if (!float.TryParse(Console.ReadLine(),out n))
                {
                    Console.WriteLine("this is not a number");
                    safe = "no";
                }
                else { safe = "yes"; }
            } while (safe != "yes");
            do
            {
                Console.WriteLine("Enter a +ive or -ve value for m");
                
                if (!float.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("this is not a number");
                    safe = "no";
                }
                else { safe = "yes"; }
            } while (safe != "yes");

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
