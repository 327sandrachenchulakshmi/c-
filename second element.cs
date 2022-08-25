using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class higharray
    {
        public static void Main()
        {
            int[] array = { 9, 15, 12, 0, 5, 98, 4, 75, 5 };
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " ");
            }
        }
    }

}