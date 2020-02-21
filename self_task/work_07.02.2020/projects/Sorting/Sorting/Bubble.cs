using System;


namespace Sorting
{
    class Bubble
    {
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;   
            bool swapDetected = false;       
            while (true)
            {
                swapDetected = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array [index] < array [index+1])
                    {
                        //swap
                        Swap.DoSwap(array, index);
                        swapDetected = true;
                    }

                }

                if (!swapDetected) break;

            }

        }



    }
}
