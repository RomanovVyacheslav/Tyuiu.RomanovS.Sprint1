using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double z = x - Math.Pow(10, Math.Sin(x)) + 20 * x * x / (3 * x * x * x) + Math.Cos(x * x - y);
            return Math.Round(z, 3);
        }
    }
}
