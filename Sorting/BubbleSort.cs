using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1].CompareTo(array[j]) < 0)
                    {
                        Swap.swap(array, j, j + 1);
                    }
                }
            }
        }

        public static T[] OptimizedSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        Swap.swap(array, j, j + 1);
                    }
                }
                if (!isAnyChange)
                {
                    break;
                }
            }
            return array;
        }
    }
}
