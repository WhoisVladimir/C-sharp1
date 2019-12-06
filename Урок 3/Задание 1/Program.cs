using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
       
                // Константинов В.А.

    struct Complex
    {
        public double a, b;

        public Complex(double v1, double v2)
        {
            a = v1;
            b = v2;
        }

        public string Print()
        {
            return $"{ a} + { b}i";
        }

        public Complex Sum(Complex N1, Complex N2)
        {
            return new Complex(N1.a + N2.a, N1.b + N2.b);
        }

        public Complex Subtract(Complex N1, Complex N2)       
        {
            return new Complex(N1.a - N2.a, N1.b - N2.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(1, 2);
            Complex z2 = new Complex(6, 9);
            Complex z3 = z1.Sum(z1, z2);
            Complex z4 = z1.Subtract(z1, z2);
           
            Console.WriteLine(z1.Print());
            Console.WriteLine(z2.Print());
            Console.WriteLine(z3.Print());
            Console.WriteLine(z4.Print());
        }
    }
}
