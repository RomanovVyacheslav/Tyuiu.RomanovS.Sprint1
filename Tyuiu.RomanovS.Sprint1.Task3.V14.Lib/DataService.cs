using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            int x = (int)number;
            int hundreds = x / 100;
            int tens = x / 10 % 10;
            int units = x % 10;
            return units * 100 + tens * 10 + hundreds;
        }
    }
}
