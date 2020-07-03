using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class MaxSubArray
    {
        public int Max(int[] array)
        {
            return FindMaximumSubArray(array, 0, array.Length - 1);
        } 

        private int FindMaximumSubArray(int[] array, int low, int high)
        {
            int left = 0 ;
            int right = 0;
            int cross = 0;
            if(low == high)
            {
                return array[low];
            }
            else
            {
                int mid = (low + high) / 2;
                left = FindMaximumSubArray(array, low, mid);
                right = FindMaximumSubArray(array, mid + 1, high);
                cross = FindMaximumCrossSubArray(array, low, mid, high);
            }

            return Math.Max(Math.Max(left, right), cross);
        }

        private int FindMaximumCrossSubArray(int[] array, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int sum = 0;
            for(int i = mid;i>= low; i--)
            {
                sum += array[i];
                if(sum > leftSum)
                {
                    leftSum = sum; 
                }
            }

            int rightSum = int.MinValue;
            sum = 0;
            for(int i = mid+1; i <=high; i++)
            {
                sum += array[i];
                if (sum > rightSum)
                {
                    rightSum = sum;
                }
            }

            return Math.Max(Math.Max(leftSum,rightSum), leftSum + rightSum);
        }
    }
}
