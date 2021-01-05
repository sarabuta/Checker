using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputChecker
{
    public class LoopNumChecker
    {
        /// <summary>
        ///     Loops message till user correctly input Integer required
        /// </summary>
        /// <param name="s">String Message</param>
        /// <returns>Int value</returns>
        public static sbyte CheckIfSByte(string s)
        {
            sbyte num;
            do
            {
                Console.Write(s);
            } while (!sbyte.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static short CheckIfShort(string s)
        {
            short num;
            do
            {
                Console.Write(s);
            } while (!short.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static ushort CheskIfUShort(string s)
        {
            ushort num;
            do
            {
                Console.Write(s);
            } while (!ushort.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static byte CheckIfByte(string s)
        {
            byte num;
            do
            {
                Console.Write(s);
            } while (!byte.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static int CheckIfInt(string s)
        {
            int num;
            do
            {
                Console.Write(s);
            } while (!int.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static uint CheckIfUInt(string s)
        {
            uint num;
            do
            {
                Console.Write(s);
            } while (!uint.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static long CheckIfLong(string s)
        {
            long num;
            do
            {
                Console.Write(s);
            } while (!long.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static ulong CheckIfULong(string s)
        {
            ulong num;
            do
            {
                Console.Write(s);
            } while (!ulong.TryParse(Console.ReadLine(), out num));
            return num;
        }

        /// <summary>
        ///      Loops message till user correctly input float value required
        /// </summary>
        /// <param name="s">String Message</param>
        /// <returns>Float values</returns>
        public static float CheckIfFloat(string s)
        {
            float num;
            do
            {
                Console.Write(s);
            } while (!float.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static double CheckIfDouble(string s)
        {
            double num;
            do
            {
                Console.Write(s);
            } while (!double.TryParse(Console.ReadLine(), out num));
            return num;
        }
        public static decimal CheckIfDecimal(string s)
        {
            decimal num;
            do
            {
                Console.Write(s);
            } while (!decimal.TryParse(Console.ReadLine(), out num));
            return num;
        }
    }
}
