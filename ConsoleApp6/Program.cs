using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }

        static void Main()
        {
            int result1 = Meters(3, 40);
            Console.WriteLine($"3 км 40 м = {result1} метров");

            int result2 = Meters(12, 540);
            Console.WriteLine($"12 км 540 м = {result2} метров");
        }
    }
}
