using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class FindPeaK
    {
        public static int FindLocalMaximum(int[] matrix)
        {            
            return FindPeak(matrix, 0, matrix.Length - 1);                            
        }

        static int FindPeak(int[] matrix, int low,int high)
        {
            int mid = (low + high) / 2;
            if (matrix[mid - 1] < matrix[mid] && matrix[mid] > matrix[mid + 1])
            {
                return matrix[mid];
            }
            else if (matrix[mid - 1] > matrix[mid])
            {
                return FindPeak(matrix, low, mid - 1);
            }
            else if (matrix[mid] < matrix[mid + 1])
            {
                return FindPeak(matrix, mid + 1, high);
            }
            return -1;
        }

        public static List<int> FindAllPeak(int[] matrix)
        {
            List<int> result = new List<int>();
            FindAllPeak(matrix, 0, matrix.Length - 1, ref result);
            return result;
        }

        static int FindAllPeak(int[] matrix, int low, int high, ref List<int> result)
        {
            int mid = (low + high) / 2;
            if(low <= high)
            {
                if (mid != low && mid != high && matrix[mid - 1] < matrix[mid] && matrix[mid] > matrix[mid + 1])
                {
                    result.Add(matrix[mid]);
                }
                result.Add(FindAllPeak(matrix, low, mid - 1, ref result));
                result.Add(FindAllPeak(matrix, mid + 1, high, ref result));
            }
            return -1;
        }
    }
}
