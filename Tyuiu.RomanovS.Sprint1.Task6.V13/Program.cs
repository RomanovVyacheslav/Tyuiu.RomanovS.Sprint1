using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RomanovS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Проверить, что буквы заданной строки упорядочены по алфавиту             *");
            Console.WriteLine("* (регистр и не-буквы не учитываются).                                     *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            // Ввод исходных данных
            Console.Write("Введите текст: ");
            string text = Console.ReadLine() ?? "";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            // Место решения задания
            if (DataService.Calculate(text))
            {
                Console.WriteLine("Буквы строки упорядочены по алфавиту.");
            }
            else
            {
                Console.WriteLine("Буквы строки не упорядочены по алфавиту.");
            }

            Console.ReadKey();
        }
    }
}
