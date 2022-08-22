using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EXERCISE
    {
        public static void Main()
        {
            int x;
            int y;
            int z;
            Console.WriteLine("enter first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            z = Convert.ToInt32(Console.ReadLine());
            int multiply = x * y * z;
            Console.WriteLine($"the output is {multiply}");

        }
    }
}
