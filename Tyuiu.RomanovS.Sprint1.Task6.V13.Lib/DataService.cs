using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.RomanovS.Sprint1.Task6.V13.Lib
{
    public class DataService
    {
        //Проверка того, что буквы строки упорядочены по алфавиту (регистр и не-буквы не учитываются)
        public static bool Calculate(string text)
        {
            var culture = new CultureInfo("ru-RU");
            char previous = '\0';
            bool hasPrevious = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]))
                {
                    continue;
                }

                char current = char.ToLower(text[i]);

                if (hasPrevious && string.Compare(previous.ToString(), current.ToString(), culture, CompareOptions.None) > 0)
                {
                    return false;
                }

                previous = current;
                hasPrevious = true;
            }

            return true;
        }
    }
}
