using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._1
/* Написать программу обмена значениями двух переменных: а) с использованием третьей переменной;
Константинов В.А. */
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            int c;

            c = b;
            b = a;
            a = c;
        }
    }
}
