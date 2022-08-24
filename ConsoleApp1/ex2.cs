using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ex2
    {
        public static int mul_num(int num1, int num2, int num3)
        {
            int mulres = num1 * num2 * num3;
            return mulres;
        }
        public static void Main()
        {
            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            int multiply = num1 * num2 * num3;
            Console.WriteLine($"the output is {mul}");
        }


    }
}

