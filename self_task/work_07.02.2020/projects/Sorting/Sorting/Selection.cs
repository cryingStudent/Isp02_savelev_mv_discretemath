using System;


namespace Sorting
{
    class Selection
    {
        public static void SelectionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;
                for (int next = index + 1; next < array.Length; next++)
                    if (array[minIndex] < array[next])
                        minIndex = next;
                if (minIndex != index)
                {
                    //swap
                    Swap.DoSwap(array, index);
                }
            }

        }
    }

}
    

