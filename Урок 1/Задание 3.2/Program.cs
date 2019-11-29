﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3._2
/* Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
Константинов В.А. */
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.Write("Введите координату x первой точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x второй точки: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между двумя точками: {Distance(x1, y1, x2, y2)}");
            Console.ReadLine();
        }
    }
}
