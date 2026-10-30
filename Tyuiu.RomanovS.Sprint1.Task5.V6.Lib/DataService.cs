using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task5.V6.Lib
{
    public class DataService
    {
        //Определение дня недели (1 - понедельник, ..., 7 - воскресенье) для k-го дня невисокосного года,
        //в котором 1 января - понедельник
        public static int Calculate(int k)
        {
            int n = (k - 1) % 7 + 1;

            return n;
        }
    }
}
