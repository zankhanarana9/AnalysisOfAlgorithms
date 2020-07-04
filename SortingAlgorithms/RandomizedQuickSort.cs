using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class RandomizedQuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        public static void Sort<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int p = RandomizedPartition(array, low, high);
                Sort(array, low, p - 1);
                Sort(array, p + 1, high);
            }
        }

        private static int RandomizedPartition<T>(T[] array, int low, int high) where T : IComparable
        {
            Random rnd = new Random();
            int p = rnd.Next(low, high + 1);
            Swap.swap(array, p, high);
            return Partition(array, low, high);
        }

        private static int Partition<T>(T[] array, int low, int high) where T : IComparable
        {
            int i = low - 1;
            T pivot = array[high];
            int repetitions = 0;
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j].CompareTo(pivot) == 0)
                {
                    repetitions += 1;
                }
                if (array[j].CompareTo(pivot) <= 0)
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
