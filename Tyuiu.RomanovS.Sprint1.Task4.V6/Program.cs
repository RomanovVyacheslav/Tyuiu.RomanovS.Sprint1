using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RomanovS.Sprint1.Task4.V6.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #6                                                               *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить значение выражения |y^2-x|/(x*y) при заданных x и y.           *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            // Ввод исходных данных
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            // Место решения задания
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Вычисление невозможно: знаменатель (x*y) равен нулю.");
            }
            else
            {
                Console.WriteLine("|y^2-x|/(x*y) = " + DataService.Calculate(x, y));
            }

            Console.ReadKey();
        }
    }
}
