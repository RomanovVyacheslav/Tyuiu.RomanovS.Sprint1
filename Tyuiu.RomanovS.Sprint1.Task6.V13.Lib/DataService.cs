using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomanovS.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            char previous = ' ';
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    char current = char.ToLower(value[i]);
                    if (previous > current)
                    {
                        return false;
                    }
                    previous = current;
                }
            }
            return true;
        }
    }
}
