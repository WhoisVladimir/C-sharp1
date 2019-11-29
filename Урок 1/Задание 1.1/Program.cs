using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1._1
/* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку: а) используя  склеивание;
 * Константинов В.А. */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите Ваш возраст: ");
            var age = Console.ReadLine();
            Console.Write("Введите Ваш рост (см): ");
            var height = Console.ReadLine();
            Console.Write("Введите Ваш вес (кг): ");
            var weight = Console.ReadLine();

            Console.WriteLine(name + " " + surname + ", в возрасте " + age + " лет, и при росте " + height + " см - вполне нормально весить " + weight + " кг!");
            Console.ReadKey();
        }
    }
}
