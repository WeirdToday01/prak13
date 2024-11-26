using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    /// <summary>
    /// Найти минимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        //task 2
        static int InputNum(string sapros)
        
            {
                Console.Write(sapros);
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
            int c = InputNum("Введите третье число: ");

            int min = GetMin(GetMin(a, b),c);

            OutputResult(min);
        }

    }
}
