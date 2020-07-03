using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class SecondLargestNumber
    {
        public static int FindSecondLargestNumber(int[] arr)
        {
            return MergeSortAndFind(arr, 0, arr.Length - 1);
        }

        static int MergeSortAndFind(int[] array, int low, int high)
        {
            int left = 0;
            int right = 0;

            if (low == high)
            {
                return Math.Max(array[low], array[high]);
            } else
            {
                int mid = (high + low) / 2;
                left = MergeSortAndFind(array, 0, mid);
                right = MergeSortAndFind(array, mid + 1, high);
            }
            return Math.Max(left, right);
        }


        private int MergeAndFind(int[] array, int low, int mid, int high)
        {
            throw new NotImplementedException();
        }
    }
}
