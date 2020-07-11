using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class DeterministicSelection
    {
        public static int DeterminedSelect(int[] array, int low, int high, int target)
        {
            if(target > 0 && target <= high - low +1)
            {
                int n = array.Length;

                int i;

                int[] median = new int[(n + 4) / 5];
                for(i =0; i < n/5; i++)
                {
                    median[i] = FindMedian(array, low + i * 5, 5);
                }

                if(i*5 < n)
                {
                    median[i] = FindMedian(array, low + i * 5, n % 5);
                    i++;
                }

                int medOfMed = (i == 1) ? median[i - 1] :
                    DeterminedSelect(median, 0, i - 1, i / 2);
                int p = Partition(array, low, high,medOfMed);
                if (p - low == target - 1)
                {
                    return array[p];
                }
                if (p > target)
                {
                    return DeterminedSelect(array, low, p - 1, target);
                }
                return DeterminedSelect(array, p + 1, high, target - p - 1);
            }
            return int.MaxValue;            
        }

        private static int FindMedian(int[] arr, int i, int length)
        {
            if(i <= length)
            {
                Array.Sort(arr, i, length);
            } else
            {
                Array.Sort(arr, length, i);
            }
            return arr[length / 2];
        }
        private static int Partition(int[] array, int low, int high, int pivot)
        {
            int k;
            for(k =0; k < high; k++)
            {
                if(array[k] == pivot)
                {
                    break;
                }
            }
            Swap.swap(array, k, high);
            //Choose pivot (median of medians)
            int i = low - 1;
            for(int j= low; j< high; j++)
            {
                if(array[j] < pivot)
                {
                    i++;
                    Swap.swap(array, i, j);
                }
            }

            Swap.swap(array, i + 1, high);
            return i + 1;
        }
    }
}
