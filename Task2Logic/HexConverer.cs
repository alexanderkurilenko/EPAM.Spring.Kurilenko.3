using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    public static class HexConverter
    {

        #region Methods
        /// <summary>
        /// Convertation to Hex  arithmetic systems
        /// </summary>
        /// <param name="value"></param>
        /// <param name="bits"></param>
        /// <returns></returns>
        public static string ConvertToHex(this long value, int bits=64)
        {
            string digits = "0123456789ABCDEF";
            char[] result = new char[bits];
            ulong valueRepresentation = GetComplementCode(value);
            for (int i = result.Length - 1; valueRepresentation > 0 && i >= 0; i--)
            {
                byte digit = (byte)(valueRepresentation % 16);
                valueRepresentation /= 16;
                result[i] = digits[digit];
            }
            return new string(result).Trim('\0');
        }
        #endregion 

        #region PrivateMethods

        /// <summary>
        /// Get  complement number code
        /// in order to have the same operation with pos and neg numbers
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static ulong GetComplementCode(long value)
        {
            ulong res = (ulong)value;
            if (value < 0)
            {
                res = (ulong)~Math.Abs(value) + 1;
            }
            return res;
        }
        #endregion
    }
}
