using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    /* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
       б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
       Константинов В.А.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваш вес (кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите Ваш рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double index = weight / Math.Pow(height, 2);
            

            Console.WriteLine($"Индекс массы вашего тела равен: {index :F2}");
            CompareIndex(index, height, weight);
            Console.ReadLine();
        }
        static void CompareIndex(double index, double height, double weight)
        {
            if (index >= 18.5 && index <= 24.99)
            {
                Console.WriteLine("Поздравляю! Вы в хорошей физической форме!");
            }
            else if (index < 18.5)
            {
                double MinWeight = 18.5 * Math.Pow(height, 2);
                Console.WriteLine($"Внимание, дефицит массы тела! Вам необходимо набрать минимум {MinWeight - weight :F2}кг.");
            }
            else
            {
                double MaxWeight = 24.99 * Math.Pow(height, 2);
                Console.WriteLine($"Внимание, у Вас избыточная масса тела! Вам необходимо похудеть минимум на {weight - MaxWeight :F2}кг.");
            }
        }
    }
}
