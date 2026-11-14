using System;

using Tyuiu.RomanovS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Определить день недели (1 - понедельник, ..., 7 - воскресенье)           *");
            Console.WriteLine("* для k-го дня невисокосного года, в котором 1 января - понедельник.       *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите номер дня года k (от 1 до 365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (k < 1 || k > 365)
            {
                Console.WriteLine("Ошибка: k должно быть от 1 до 365.");
            }
            else
            {
                Console.WriteLine("Номер дня недели n = " + new DataService().Calculate(k));
            }

            Console.ReadKey();
        }
    }
}
