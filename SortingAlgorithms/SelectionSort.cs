using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] matrix) where T : IComparable
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int minIndex = i;
                T minValue = matrix[i];
                for (int j = i; j < matrix.Length; j++)
                {
                    if (matrix[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = matrix[j];
                    }
                }
                Swap.swap(matrix, i, minIndex);
            }
        }
    }
}
