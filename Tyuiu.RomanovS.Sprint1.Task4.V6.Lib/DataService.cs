using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task4.V6.Lib
{
    public class DataService
    {
        //Вычисление выражения |y^2 - x| / (x*y)
        public static double Calculate(double x, double y)
        {
            double result = Math.Abs(Math.Pow(y, 2) - x) / (x * y);
            result = Math.Round(result, 3);

            return result;
        }
    }
}
