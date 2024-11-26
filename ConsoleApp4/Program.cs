using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{


    /// <summary>
    /// Определить статический метод int Seconds (int h, int m, int s), который принимает три целых аргумента
    /// (часы h, минуты m и секунды s) и возвращает количество секунд, прошедших с начала дня.
    /// Используя этот метод, вычислить количество секунд, прошедших с начала дня при:    
    /// a) 0 ч 40 мин 20 с      b)3 ч 10 мин 50 с
    /// </summary>
    class Program
    {
        //task 4
        static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
        }
        static int InputNum(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void OutputResult(int seconds)
        {
            Console.WriteLine("Количество секунд с начала дня: " + seconds);
            
        }

        static void Main()
        {
            int h = InputNum("Введите первое число: ");
            int m = InputNum("Введите второе число: ");
            int s = InputNum("Введите второе число: ");
            int secondsA = Seconds(h, m, s);
            OutputResult(secondsA);

            Console.ReadKey();
        }
    }
}
