using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    internal class InversionArray
    {
        internal static int Sort<T>(T[] array) where T: IComparable
        {
            int c = SortAndCount(array, 0, array.Length - 1);
            return c;
        }

        internal static int SortAndCount<T>(T[] array, int low, int high) where T: IComparable
        {
            int  inv_count = 0;
            if(high > low)
            {
                int mid = (low + high) / 2;
                inv_count += SortAndCount(array, low, mid);
                inv_count += SortAndCount(array, mid + 1, high);
                inv_count += MergeCountSplit(array, low, mid, high);
            }
            return inv_count;
        }

        private static int MergeCountSplit<T>(T[] array, int low, int mid, int high) where T : IComparable
        {
            int start = low;
            int start2 = mid+1;
            int n = 0;
            int count = 0;
            T[] resultArray = new T[high - low + 1];
            while (start <= mid && start2 <= high)
            {
                if (array[start].CompareTo(array[start2]) < 0)
                {
                    resultArray[n++] = array[start++];
                }
                else
                {
                    resultArray[n++] = array[start2++];
                    count = count + (mid - start + 1);
                }
            }

            while (start <= mid)
            {
                resultArray[n++] = array[start++];
            }
            while (start2 <= high)
            {
                resultArray[n++] = array[start2++];
            }

            n = 0;
            for (int i = low; i <= high && n < resultArray.Length; i++, n++)
            {
                array[i] = resultArray[n];
            }
            return count;
        }
    }
}
