using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class CountingSort
    {
        public static int[] Sort(int[] array, int k)
        {
            int[] result = new int[array.Length];
            int[] temp = new int[k+1];

            for(int i =0; i< array.Length; i++)
            {
                temp[array[i]]++;
            }

            for(int i =1; i <= k;i++)
            {
                temp[i] = temp[i] + temp[i - 1];
            }

            for(int j=array.Length-1; j>=0 ;j--)
            {
                result[temp[array[j]]-1] = array[j];
                temp[array[j]]--;
            }
            return result;
        }
    }
}
