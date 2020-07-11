using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class QuickSortHoarePartition
    {
        public static void Sort<T>(T[] matrix) where T : IComparable
        {
            Sort(matrix, 0, matrix.Length - 1);
        }

        private static T[] Sort<T>(T[] matrix, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(matrix, lower, upper);
                Sort(matrix, lower, p);
                Sort(matrix, p + 1, upper);
            }
            return matrix;
        }

        private static int Partition<T>(T[] matrix, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = matrix[lower];
            do
            {
                while (matrix[i].CompareTo(pivot) < 0) { i++; }
                while (matrix[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Swap.swap(matrix, i, j);
            } while (i <= j);
            return j;
        }
    }
}
