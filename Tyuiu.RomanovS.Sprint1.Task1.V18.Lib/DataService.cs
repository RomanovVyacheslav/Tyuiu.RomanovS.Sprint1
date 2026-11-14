using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task1.V18.Lib
{
    public class DataService : ISprint1Task1V18
    {
        public double Calculate(double x, double y)
        {
            double result = (x * y) / (x + 1) - 3;
            return Math.Round(result, 3);
        }
    }
}
