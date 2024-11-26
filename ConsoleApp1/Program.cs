using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    /// <summary>
    /// Найти минимальную величину из двух целых переменных a, b, используя
    /// вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        //task 1
        static int InputNum(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static int GetMin(int a, int b)
        {
            return a < b ? a : b;
        }

        static void OutputResult(int min)
        {
            Console.WriteLine("Минимальное значение: " + min);
        }

        static void Main()
        {
            int a = InputNum("Введите первое число: ");
            int b = InputNum("Введите второе число: ");

            int min = GetMin(a, b);

            OutputResult(min);
        }
    }
    }
