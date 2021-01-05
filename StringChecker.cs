using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChecker
{
    public class StringChecker
    {
        public static bool startsWithChar(string InputStr, char start)
        {
            return (InputStr.ToLower()[0] == Char.ToLower(start));
        }

        public static bool contains(string InputStr, string str)
        {
            return (InputStr.ToLower().Contains(str.ToLower()));
        }

        public static bool strLengthChecker(string inputStr, int minLength = 0, int maxLength = 30)
        {
            string s = inputStr.Replace(" ", "");
            return (s.Length <= maxLength && s.Length >= minLength);
        }
    }
}
