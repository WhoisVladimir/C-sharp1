using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    //  Написать метод подсчета количества цифр числа.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int summ = 0;
                       
            summ = RecursiveSumm(number);
            Console.WriteLine(summ);
            Console.Read();
        }
        static int RecursiveSumm(int x)
        {
            while (x != 0)
            {
                return RecursiveSumm(x / 10) + x % 10;
            }
            return 0;
        }
       

    }
}
