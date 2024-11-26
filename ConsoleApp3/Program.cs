using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    /// <summary>
    /// Найти s=min(a, b) + min(c, d), используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        //task 3
        static int InputNum(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static int GetMin(int a, int b)
        {
            return a < b ? a : b;
        }

        static void OutputResult(int result)
        {
            Console.WriteLine("Результат: " + result);
        }

        static void Main()
        {
            int a = InputNum("Введите первое число (a): ");
            int b = InputNum("Введите второе число (b): ");
            int c = InputNum("Введите третье число (c): ");
            int d = InputNum("Введите четвертое число (d): ");

            int result = GetMin(a, b) + GetMin(c, d);

            OutputResult(result);
        }
    }
}
