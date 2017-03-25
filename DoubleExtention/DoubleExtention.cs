using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleExtention
{
    /// <summary>
    /// Class that implement an extention method for double
    /// </summary>
    public static class DoubleExtention
    {
        /// <summary>
        /// Method that returns a string of binary representaion of double value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Binary String</returns>
        public static string ToBinarySting(this double value)
        {
            long int64Bits = BitConverter.DoubleToInt64Bits(value);

            string result = string.Empty;
            
            for (int i = 63; i >= 0; i--)
            {
                result += Convert.ToString((int64Bits >> i) & 1);
            }
            
            return result;
        }
    }
}
