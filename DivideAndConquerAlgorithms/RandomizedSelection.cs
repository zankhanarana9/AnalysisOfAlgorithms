using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class RandomizedSelection
    {
        public static int RandomSelect(int[] array, int low, int high, int target)
        {
            if(array.Length == 1)
            {
                return array[0];
            }
            int p = RandomizedPartition(array, low, high);
            if(p-low == target-1)
            {
                return array[p];
            } else if(p > target)
            {
                // left side of p
                return RandomSelect(array, low, p-1, target);                
            }

            //right side of p
            return RandomSelect(array, p+1,high, target-p-1);
        }

        private static int RandomizedPartition(int[] array, int low, int high) 
        {
            Random rnd = new Random();
            int p = rnd.Next(low, high + 1);
            Swap.swap(array, p, high);
            return Partition(array, low, high);
        }

        private static int Partition(int[] array, int low, int high)
        {
            int i = low - 1;
            int pivot = array[high];
            for(int j =low; j< high; j++)
            {
                if(array[j] <= pivot)
                {
                    i++;
                    Swap.swap(array, i, j);
                }
            }
            Swap.swap(array, i+1, high);
            return i+1;
        }
    }
}
