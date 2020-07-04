using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                Sort(array, low, mid);
                Sort(array, mid + 1, high);

                Merge2(array, low, mid, high);
            }
        }

        public static void Merge2<T>(T[] array, int low, int mid, int high) where T : IComparable
        {
            int start = low;
            int start2 = mid + 1;
            int n = 0;

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
        }

        public static void Merge<T>(T[] array, int low, int mid, int high) where T : IComparable
        {

            int n1 = mid - low + 1;
            int n2 = high - mid;

            T[] temp1 = new T[n1];
            T[] temp2 = new T[n2];

            for (int i = 0; i < n1; i++)
            {
                temp1[i] = array[low + i];
            }

            for (int j = 0; j < n2; j++)
            {
                temp2[j] = array[mid + 1 + j];
            }

            int start = 0;
            int start2 = 0;

            //Initial index of merged subarray 
            int n = low;

            while (start < n1 && start2 < n2)
            {
                if (temp1[start].CompareTo(temp2[start2]) < 0)
                {
                    array[n++] = temp1[start++];
                }
                else
                {
                    array[n++] = temp2[start2++];
                }
            }
            while (start < n1)
            {
                array[n++] = temp1[start++];
            }

            while (start2 < n2)
            {
                array[n++] = temp2[start2++];
            }
        }
    }
}
