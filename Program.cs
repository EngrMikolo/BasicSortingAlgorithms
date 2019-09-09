using System;
using System.Diagnostics;

namespace Basic_Sorting_Algorithms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random(100);
            int numberOfItems = 20;
            MyArray theArray = new MyArray(numberOfItems);

            for (int i = 0; i < numberOfItems; i++)
                theArray.Insert((int)(randomNumberGenerator.NextDouble() * 100));

            var bubbleSortStopwatch = Stopwatch.StartNew();
            theArray.BubbleSort();
            bubbleSortStopwatch.Stop();
            theArray.DisplayElements();
            Console.WriteLine("\nTime for bubble sort: " + bubbleSortStopwatch.Elapsed.TotalMilliseconds);

            theArray.Clear();
            for (int i = 0; i < numberOfItems; i++)
                theArray.Insert((int)(randomNumberGenerator.NextDouble() * 100));

            var selectionSortStopwatch = Stopwatch.StartNew();
            theArray.SelectionSort();
            selectionSortStopwatch.Stop();
            theArray.DisplayElements();
            Console.WriteLine("\nTime for selection sort: " + selectionSortStopwatch.Elapsed.TotalMilliseconds);

            theArray.Clear();
            for (int i = 0; i < numberOfItems; i++)
                theArray.Insert((int)(randomNumberGenerator.NextDouble() * 100));

            var insertionSortStopwatch = Stopwatch.StartNew();
            theArray.InsertionSort();
            insertionSortStopwatch.Stop();
            theArray.DisplayElements();
            Console.WriteLine("\nTime for insertion sort: " + insertionSortStopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
