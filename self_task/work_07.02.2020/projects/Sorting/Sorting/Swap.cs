using System;

namespace Sorting
{
    class Swap
    {
        public static void DoSwap(int[] array, int index)
        {

            int tmp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = tmp;
        }



        
    }
}
