using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class SearchInMatrix
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            return SearchMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1), matrix.GetLength(1) / 2, target);
        }

        private static bool SearchMatrix(int[,] matrix, int rows, int columns, int mid, int target)
        {

            bool found = SearchColumn(matrix, rows, mid, target);

            if (found) return found;

            if (mid == 0 || mid == columns - 1)
                return false;

            if (matrix[mid, mid] < target)
            {
                return SearchMatrix(matrix, rows, columns, mid + mid / 2, target);
            }

            return SearchMatrix(matrix, rows, columns, mid - mid / 2, target);
        }

        private static bool SearchColumn(int[,] matrix, int rows, int mid, int target)
        {
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, mid] == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
