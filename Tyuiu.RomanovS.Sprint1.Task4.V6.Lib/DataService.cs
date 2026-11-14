using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {
            double result = Math.Abs(y * y - x) / (x * y);
            return Math.Round(result, 3);
        }
    }
}
