using System;
using System.Collections.Generic;
using Lab3.SortingAlgorithms;
using System.Diagnostics;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region setup
            int N = 100000;

            // Generate random list
            List<int> intList = GenerateRandomIntList(N, N * 5);

            // Generate reverse-ordered list
            List<int> intListReversed = new List<int>();
            for (int i = N - 1; i > -1; i--)
            {
                intListReversed.Add(i);
            }

            // Generate mostly-ordered list
            List<int> intListOrdered = new List<int>();
            for (int i = 0; i < N; i++)
            {
                intListOrdered.Add(i);
            }
            intListOrdered = TinyShuffle(intListOrdered);
            #endregion

            #region random

            // Selection
            Console.WriteLine("SELECTION SORT");
            SelectionSort<int> selectionSort = new SelectionSort<int>();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(selectionSort, intListCopy);
            }

            // Insertion
            Console.WriteLine("INSERTION SORT");
            InsertionSort<int> insertionSort = new InsertionSort<int>();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(insertionSort, intListCopy);
            }

            // Merge
            Console.WriteLine("MERGESORT");
            MergeSort<int> mergeSort = new MergeSort<int>();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(mergeSort, intListCopy);
            }

            // Quick
            Console.WriteLine("QUICKSORT");
            QuickSort<int> quickSort = new QuickSort<int>();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(quickSort, intListCopy);
            }

            // Counting
            Console.WriteLine("COUNTING SORT");
            CountingSort countingSort = new CountingSort();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(countingSort, intListCopy);
            }

            // Radix
            Console.WriteLine("RADIX SORT");
            RadixSort radixSort = new RadixSort();
            for (int i = 0; i < 11; i++)
            {
                List<int> intListCopy = new List<int>(intList);   // make a copy of the original unsorted array
                TimeSort(radixSort, intListCopy);
            }
            #endregion

            #region reversed
            #endregion

            #region ordered
            #endregion
        }

        public static void TimeSort<T>(ISortable<T> sortable, List<T> items) where T : IComparable<T>
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(ref items);

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            //Console.WriteLine(elapsedTime);
            Console.WriteLine(ts.TotalSeconds);

        }

        public static void TimeSort(ISortableInt sortable, List<int> items)
        {
            // start timer
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortable.Sort(items.ToArray());

            // end timer
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // print info
            //Console.WriteLine(sortable.GetType().ToString());

            // print elapsed time data
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //ts.Hours, ts.Minutes, ts.Seconds,
            //ts.Milliseconds / 10);
            //Console.WriteLine(elapsedTime);
            Console.WriteLine(ts.TotalSeconds);
        }


        public static List<int> GenerateRandomIntList(int length, int maxValue)
        {
            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.Next(maxValue));
            }

            return list;
        }

        public static List<double> GenerateRandomDoubleList(int length, double maxValue)
        {
            List<double> list = new List<double>();

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                list.Add(random.NextDouble() * maxValue);
            }

            return list;
        }

        public static List<int> TinyShuffle(List<int> list)
        {
            // randomly shuffle 5% of the list
            return new List<int>();
        }
    }
}
