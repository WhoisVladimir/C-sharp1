using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    /* Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
    На выходе истина, если прошел авторизацию, и ложь, если не прошел 
    (Логин: root, Password: GeekBrains).
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    С помощью цикла do while ограничить ввод пароля тремя попытками. */
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool a;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                i++;
                a = CompareKeys(login, password);

            } while (i < 3 && a == false);
            
        }
        static bool CompareKeys(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                Console.WriteLine("Вы авторизированы!");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("Вы ввели неверное имя пользователя или пароль!");
                Console.ReadLine();
                return false;
            }
        }
    }
}
