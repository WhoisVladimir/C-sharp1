using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1.б
  //  б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    // Константинов В.А.
{
    public class Complex
    {
        double a;
        double b;
        public Complex()
        {
            a = 0;
            b = 0;
        }
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex Plus(Complex z2)
        {
            Complex z3 = new Complex();
            z3.a = z2.a + a;
            z3.b = z2.b + b;
            return z3;
        }
        public Complex Minus(Complex z2)
        {
            Complex z3 = new Complex();
            z3.a = a - z2.a;
            z3.b = b - z2.b;
            return z3;
        }
        public Complex Multiply(Complex z2)
        {
            Complex z3 = new Complex();
            z3.a = a * z2.a - b * z2.b;
            z3.b = a * z2.b + b * z2.a;
            return z3;
        }
        public string ToString()
        {
            return $"{a} + {b}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1;
            z1 = new Complex(3, 3);
            Complex z2 = new Complex(2, 2);
            Complex Sum = z1.Plus(z2);
            Complex Subtract = z1.Minus(z2);
            Complex Increase = z1.Multiply(z2);
          
            Console.WriteLine(Sum.ToString());
            Console.WriteLine(Subtract.ToString());
            Console.WriteLine(Increase.ToString());
        }
    }

   
}
