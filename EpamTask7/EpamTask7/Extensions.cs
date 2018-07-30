using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask7
{
    static class Extensions
    {
        #region int[]
        public static int Sum(this int[] array)
        {
            var sum = 0;
            
            foreach (var numb in array)
                sum += numb;

            return sum;
        }
        #endregion

        #region string
        public static bool IsPositiveInt(this string number)
        {
            for (var i = 0; i < number.Length; i++)
            {
                if (!((number[i] >= '0') && (number[i] <= '9')))
                    return false;
            }

            return true;
        }
        #endregion
    }
}
