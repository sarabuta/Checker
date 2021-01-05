using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChecker
{
    public class LoopStrChecker
    {
        public static string CheckforString(string s)
        {
            string input;
            do
            {
                Console.Write(s);
                input = Console.ReadLine();
            } while (input.Trim(' ') == "");
            return input;
        }
        public static char[] CheckforChar(string s)
        {
            string input;
            do
            {
                Console.Write(s);
                input = Console.ReadLine();
            } while (input.Trim(' ') == "");
            return input.ToCharArray();
        }
    }
}
