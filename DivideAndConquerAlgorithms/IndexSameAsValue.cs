using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class IndexSameAsValue
    {
        public static bool FindIndexSameAsValue(int[] array)
        {
            return FindIndexSameAsValue(array, 0, array.Length - 1);
        }

        static bool FindIndexSameAsValue(int[] array, int low, int high)
        {           
            int mid = (low + high) / 2;
            if(high >= low)
            {
                if (array[mid] == mid)
                {
                    return true;
                }
                else if (array[mid] > mid)
                {
                    return FindIndexSameAsValue(array, low, mid - 1);
                }
                else
                {
                    return FindIndexSameAsValue(array, mid + 1, high);
                }
            }
            return false;
        }
    }
}
