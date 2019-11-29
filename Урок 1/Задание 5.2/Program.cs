using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._2
/*  Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 б) *Сделать задание, только вывод организовать в центре экрана.
 Константинов В.А. */
{
    class Program
    {
        static void CenterText()
        {
             Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
        }

        static void Main(string[] args)
        {
            CenterText();
            Console.Write("Имя: Владимир. \nФамилия: Константинов. \nГород: Одинцово."); // Хотелось бы понять как продолжить столбец по центру, в рамках одного текста.
            Console.Read();
        }
    }
}
