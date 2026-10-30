using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RomanovS.Sprint1.Task0.V10.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить значение выражения (3/6-4)*3.                                  *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* Выражение: (3/6-4)*3                                                     *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            // Место решения задания
            Console.WriteLine("Результат выражения (3/6-4)*3 = " + DataService.CalculateExpression());

            Console.ReadKey();
        }
    }
}
