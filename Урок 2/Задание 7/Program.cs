using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
  /* a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    б) * Разработать рекурсивный метод, который считает сумму чисел от a до b. 
    Константинов В.А.*/
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон чисел.");
            Console.Write("От: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int b = int.Parse(Console.ReadLine());

            RecursiveMethodA(a, b);
            Console.Read();
        }
        
        static int RecursiveMethodA(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine (RecursiveMethodA(a, b - 1));
            }
            return b + 1;
            
        }
    }
}
