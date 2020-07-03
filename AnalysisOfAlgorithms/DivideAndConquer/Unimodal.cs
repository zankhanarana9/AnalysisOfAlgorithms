using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class Unimodal
    {
        public static int FindMaxUnimodal(int[] array)
        {
            return FindMaxUnimodal(array, 0, array.Length - 1);
        }

        static int FindMaxUnimodal(int[] array, int low, int high)
        {
            if(low == high -1)
            {
                return array[low];
            } else
            {
                int mid = (low + high) / 2;
                if(array[mid] > array[mid+1])
                {
                    return FindMaxUnimodal(array, low, mid);
                } else
                {
                    return FindMaxUnimodal(array, mid + 1, high);
                }
            }
        }
    }
}
