using System;


namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mass = new int[] { 1, 3, 5, 1, 4, 7, 1, -2 };
            
            //bubble
            Bubble.BubbleSort(mass);

            foreach (int item in mass)
                Console.Write(item + " ");
            Console.WriteLine(" <--- BubbleSort");


            //Selection sort
            Console.WriteLine();
            Selection.SelectionSort(mass);
           
            foreach (int item in mass)
                Console.Write(item + " ");
            Console.WriteLine(" <--- Selection sort");


            Console.ReadKey();

        }
    }
}
