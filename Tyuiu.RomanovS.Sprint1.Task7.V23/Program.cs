using Tyuiu.RomanovS.Sprint1.Task7.V23.Lib;

namespace Tyuiu.RomanovS.Sprint1.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Романов В. И. | ПИНб-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Романов Вячеслав Иванович | ПИНб-26-1                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Вычислить z = x - 10^(sin x) + 20x^2 / (3x^3) + cos(x^2 - y).            *");
            Console.WriteLine("* Результат округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (x == 0)
            {
                Console.WriteLine("Вычисление невозможно: при x = 0 знаменатель равен нулю.");
            }
            else
            {
                Console.WriteLine("z = " + new DataService().Calculate(x, y));
            }

            Console.ReadKey();
        }
    }
}
