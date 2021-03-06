﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {

        public static void Sort<T>(T[] matrix) where T : IComparable
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                int j = i;
                while (j > 0 && matrix[j].CompareTo(matrix[j - 1]) < 0)
                {
                    Swap.swap(matrix, j, j - 1);
                    j--;
                }
            }
        }

        public static void RecuriveSort<T>(T[] matrix, int n) where T : IComparable
        {
            if (n <= 1)
            {
                return;
            }

            RecuriveSort(matrix, n - 1);
            T last = matrix[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                if (last.CompareTo(matrix[i]) < 0)
                {
                    //last = matrix[i];
                    Swap.swap(matrix, i, i + 1);

                }
            }
        }

        /// <summary>
        /// Implementation from Geeks for Geeks
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="n"></param>

        public static void insertionSortRecursive<T>(T[] arr, int n) where T : IComparable
        {
            // Base case 
            if (n <= 1)
                return;

            // Sort first n-1 elements 
            insertionSortRecursive(arr, n - 1);

            // Insert last element at  
            // its correct position 
            // in sorted matrix. 
            T last = arr[n - 1];
            int j = n - 2;

            /* Move elements of arr[0..i-1],  
            that are greater than key, to  
            one position ahead of their 
            current position */
            while (j >= 0 && arr[j].CompareTo(last) > 0)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = last;
        }

    }
}
