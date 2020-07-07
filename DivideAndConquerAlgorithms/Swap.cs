using System;
using System.Collections.Generic;
using System.Text;

namespace DivideAndConquer
{
    public static class Swap
    {
        public static void swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
