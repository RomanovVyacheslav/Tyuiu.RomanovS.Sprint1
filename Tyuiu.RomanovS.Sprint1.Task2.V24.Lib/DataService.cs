using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task2.V24.Lib
{
    public class DataService
    {
        //Вычисление квадрата разницы двух чисел
        public static int Calculate(int x, int y)
        {
            int difference = x - y;
            int result = difference * difference;

            return result;
        }
    }
}
