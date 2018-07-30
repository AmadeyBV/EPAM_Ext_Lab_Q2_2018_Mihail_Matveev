using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask7
{
    class Search
    {
        public int[] PositiveElements(int[] array)
        {
            var listNumber = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    listNumber.Add(array[i]);
            }

            return listNumber.ToArray();
        }
    }
}
