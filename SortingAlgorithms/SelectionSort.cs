using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                T minValue = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap.swap(array, i, minIndex);
            }
        }
    }
}
