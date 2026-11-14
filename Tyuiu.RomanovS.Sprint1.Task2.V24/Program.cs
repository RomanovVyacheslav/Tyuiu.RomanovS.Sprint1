using System;

using Tyuiu.RomanovS.Sprint1.Task2.V24.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить квадрат разницы двух целых чисел.                              *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Квадрат разницы = " + new DataService().CalculateDiffSquare(x, y));

            Console.ReadKey();
        }
    }
}
