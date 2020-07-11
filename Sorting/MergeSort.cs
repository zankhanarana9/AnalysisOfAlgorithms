using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] matrix, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                Sort(matrix, low, mid);
                Sort(matrix, mid + 1, high);

                Merge2(matrix, low, mid, high);
            }
        }

        public static void Merge2<T>(T[] matrix, int low, int mid, int high) where T : IComparable
        {
            int start = low;
            int start2 = mid + 1;
            int n = 0;

            T[] resultmatrix = new T[high - low + 1];
            while (start <= mid && start2 <= high)
            {
                if (matrix[start].CompareTo(matrix[start2]) < 0)
                {
                    resultmatrix[n++] = matrix[start++];
                }
                else
                {
                    resultmatrix[n++] = matrix[start2++];
                }
            }

            while (start <= mid)
            {
                resultmatrix[n++] = matrix[start++];
            }
            while (start2 <= high)
            {
                resultmatrix[n++] = matrix[start2++];
            }

            n = 0;
            for (int i = low; i <= high && n < resultmatrix.Length; i++, n++)
            {
                matrix[i] = resultmatrix[n];
            }
        }

        public static void Merge<T>(T[] matrix, int low, int mid, int high) where T : IComparable
        {

            int n1 = mid - low + 1;
            int n2 = high - mid;

            T[] temp1 = new T[n1];
            T[] temp2 = new T[n2];

            for (int i = 0; i < n1; i++)
            {
                temp1[i] = matrix[low + i];
            }

            for (int j = 0; j < n2; j++)
            {
                temp2[j] = matrix[mid + 1 + j];
            }

            int start = 0;
            int start2 = 0;

            //Initial index of merged submatrix 
            int n = low;

            while (start < n1 && start2 < n2)
            {
                if (temp1[start].CompareTo(temp2[start2]) < 0)
                {
                    matrix[n++] = temp1[start++];
                }
                else
                {
                    matrix[n++] = temp2[start2++];
                }
            }
            while (start < n1)
            {
                matrix[n++] = temp1[start++];
            }

            while (start2 < n2)
            {
                matrix[n++] = temp2[start2++];
            }
        }
    }
}
