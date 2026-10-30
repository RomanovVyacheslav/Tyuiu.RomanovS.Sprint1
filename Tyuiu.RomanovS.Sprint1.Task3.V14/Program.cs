using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RomanovS.Sprint1.Task3.V14.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Найти число, полученное выписыванием в обратном порядке цифр             *");
            Console.WriteLine("* заданного трехзначного числа.                                            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            // Ввод исходных данных
            Console.Write("Введите трехзначное число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            // Место решения задания
            Console.WriteLine("Число в обратном порядке цифр = " + DataService.Calculate(x));

            Console.ReadKey();
        }
    }
}
