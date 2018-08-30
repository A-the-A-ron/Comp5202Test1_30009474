using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calcultae the average of 10 numbers.");
            int c = 1;
            float x = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number " + c);

                float y = float.Parse(Console.ReadLine());
                x= x + y;
                c++;
            }
            x = x / 10;
            Console.WriteLine("the average of these numbers is: " + x);
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
