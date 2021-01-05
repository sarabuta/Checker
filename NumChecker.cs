using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChecker
{
    public class NumChecker
    {
        public static bool evenChecker(int inputNum)
        {
            return (inputNum % 2 == 0);
        }

        public static bool evenChecker(double inputNum)
        {
            return (inputNum % 2 == 0);
        }

        public static bool numRangeChecker<T>(T item, T minRange, T maxRange) where T : IComparable
        {
            return (item.CompareTo(maxRange) == -1 && item.CompareTo(minRange) >= 0);
        }

    }
}
