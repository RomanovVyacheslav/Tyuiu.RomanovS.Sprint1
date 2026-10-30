using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task3.V14.Lib
{
    public class DataService
    {
        //Число, полученное выписыванием в обратном порядке цифр трехзначного числа
        public static double Calculate(int x)
        {
            int hundreds = x / 100;
            int tens = x / 10 % 10;
            int units = x % 10;

            double result = units * 100 + tens * 10 + hundreds;
            result = Math.Round(result, 3);

            return result;
        }
    }
}
