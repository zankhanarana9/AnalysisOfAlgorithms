using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class LocalMinima
    {
        public static int FindLocalMinimum(int[,] matrix)
        {
            return LocalMinimum(matrix, matrix.GetLength(0), matrix.GetLength(1), matrix.GetLength(1)/2);
        }

        static int LocalMinimum(int[,] matrix, int rows, int columns, int mid)
        {
            int min = Min(matrix, rows, mid);
            int minIndex = MinIndex(matrix, rows, mid);

            //if minIndex  is  the  also the local minimum return it;
            
            if(minIndex == 0 || minIndex == columns -1)
            {
                return min;
            }

            //min <= matrix[minIndex - 1, mid] && min <= matrix[minIndex + 1, mid] &&
                
            if ( min <= matrix[minIndex,mid-1] && min <= matrix[minIndex,mid])
            {
                return min;
            }

            if(matrix[minIndex,mid - 1] <  min)
            {
                //minimum lies in the left
                return LocalMinimum(matrix, rows, columns,mid-  mid / 2);
            }

            return LocalMinimum(matrix, rows, columns, mid + mid / 2);
        }

        private static int Min(int[,] matrix, int rows, int mid)
        {
            int min = int.MaxValue;
            for(int i =0; i < rows; i++)
            {
                if(matrix[i,mid] < min)
                {
                    min = matrix[i,mid];
                }
            }
            return min;
        }

        private static int MinIndex(int[,] matrix, int rows, int mid)
        {
            int ind = -1;
            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i,mid] < min)
                {
                    ind = i;
                    min = matrix[i, mid];
                }
            }
            return ind;
        }
    }
}
