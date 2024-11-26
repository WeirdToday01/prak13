using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public static double Average(int m, int n)
        {
            int sum = 0;
            int count = 0;

            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }

            return (double)sum / count;
        }

        static void Main()
        {
            Console.WriteLine("Среднее арифметическое от 1 до 10: " + Average(1, 10));

            Console.WriteLine("Среднее арифметическое от 20 до 40: " + Average(20, 40));

            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Среднее арифметическое от {a} до {b}: " + Average(a, b));
        }
    }
}
