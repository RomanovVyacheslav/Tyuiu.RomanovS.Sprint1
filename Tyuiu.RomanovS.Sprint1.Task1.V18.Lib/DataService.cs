using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task1.V18.Lib
{
    public class DataService
    {
        //Вычисление выражения (x*y)/(x+1)-3
        public static double Calculate(double x, double y)
        {
            double result = (x * y) / (x + 1) - 3;
            result = Math.Round(result, 3);

            return result;
        }
    }
}
