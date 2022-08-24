using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _1day2
    {
        public static int mul_num(int num1, int num2, int num3)
        {
            int mulres = num1 * num2 * num3;
            return mulres;
        }
        public static void Main()
        {
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
