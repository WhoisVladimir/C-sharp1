using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    { 
        // Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            Console.Write("ВВедите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("ВВедите третье число: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareNumbers(a, b, c));
            Console.ReadLine();
            
        }

        static int CompareNumbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
            
        }
    }
}
