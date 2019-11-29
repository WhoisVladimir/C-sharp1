using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
/*Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 Константинов В.А.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваш вес (кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите Ваш рост (м): ");
            double height = Convert.ToDouble(Console.ReadLine());
            double index = weight / (height * height);

            Console.WriteLine($"Индекс массы вашего тела равен: {index}");
            Console.Read();
        }
    }
}
