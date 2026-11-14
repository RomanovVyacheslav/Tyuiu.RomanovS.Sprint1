using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int x, int y)
        {
            return (x - y) * (x - y);
        }
    }
}
