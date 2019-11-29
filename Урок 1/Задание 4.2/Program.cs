using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._2
/* Написать программу обмена значениями двух переменных: б) *без использования третьей переменной.
 Константинов В.А.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 2;

            (a, b) = (b, a);
        }
    }
}
