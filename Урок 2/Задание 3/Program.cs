using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int numbers = 0;

            Console.WriteLine($"Сумма нечётных чисел от 0 до {x}: {Summ(x, numbers)}");
            Console.Read();
        }
        static int Summ(int x, int numbers)
        {
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    numbers = numbers + i;
                }
            }
            return numbers;
        }
    }
}
