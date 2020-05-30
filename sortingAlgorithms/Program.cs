 using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;

namespace sortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----bubble sort----

            //read input
            Console.WriteLine("enter the length of input");
            int arrLen = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLen];

            //read elements into array
            Console.WriteLine("Enter elements");

            for (int i = 0; i < arrLen; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Before sorting");

            Program Pgmobject = new Program();

            Pgmobject.printElements(arr);

            Console.WriteLine("1 - bubble sort, 2 - selection sort, 3 - insertion sort, 4 - quick sort");

            int selectedSort = int.Parse(Console.ReadLine());

            switch (selectedSort)
            {
                case 1:
                    {
                        Pgmobject.bubbleSort(arr);
                        break;
                    }
                case 2:
                    {
                        Pgmobject.selectionSort(arr);
                        break;
                    }
                case 3:
                    {
                        Pgmobject.insertionSort(arr);
                        break;
                    }
                case 4:
                    {
                        Pgmobject.quickSort(arr);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("fuck you!");
                        break;
                    }
            }

        }

        public void printElements(int[] arr)
        {
            Console.WriteLine("Elements in array:- ");

            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        //bubble sort
        public void bubbleSort(int[] arr)
        {
            Console.WriteLine("Bubble Sort");
            bool swapped = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    swapped = false;
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = 0;
                        swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                        swapped = true;
                    }

                    if (swapped == false)
                    {
                        break;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public void selectionSort(int[] arr)
        {
            int selSorLen = arr.Length;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = 0;
                        swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                    }

                foreach (int ival in arr)
                {
                    Console.Write("{0} ", ival);
                }
                Console.WriteLine();

                //for(int j = i; j < arr.Length; j++)
                //{
                //if (arr[j] > arr[j + 1])
                //{
                //    //pushInToArray(arr[j], 0);
                //    //pushArrLen++;
                //    int swapVar = 0;
                //    swapVar = arr[j];
                //    arr[j] = arr[j + 1];
                //    arr[j + 1] = swapVar;
                //}
                //}
            }

            Console.WriteLine("After selection sort");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public void insertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        {
                            int swapVar = 0;
                            swapVar = arr[j-1];
                            arr[j-1] = arr[j];
                            arr[j] = swapVar;
                        }
                    }
                }
                Console.WriteLine("after each i loop");
                foreach (int ival in arr)
                {
                    Console.Write("{0} ", ival);
                }
                Console.WriteLine();
            }
            Console.WriteLine("After insertion sort");
            foreach (int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        public void quickSort(int[] arr)
        {
            Console.WriteLine("inside quick sort");
            int LB = 0;
            int UB = arr.Length - 1;
            Console.WriteLine("before sending in begininning");
            showArray(arr);
            partition(arr, LB, UB);
            Console.WriteLine("finally!!");
            showArray(arr);
        }

        public void partition(int[] arr,int lb,int ub)
        {
            int pivot = lb;
            int start = lb;
            int end = ub;
            while(start <= end)
            {
                while(arr[start] <= arr[pivot])
                {
                    start++;
                }
                while(arr[end] > arr[pivot])
                {
                    if(end>0)
                    end--;
                }
                //swap start and end
                if(start < end)
                {
                    int temp = 0;
                    temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                }
            }
            //swap a[lb] and pivot
            int tempv = 0;
            tempv = arr[lb];
            arr[lb] = arr[end];
            arr[end] = tempv;

            partition(arr, start, end - 1);
            Console.WriteLine("first half");
            showArray(arr);
            partition(arr, end+1, arr.Length-1);
            Console.WriteLine("second half");
            showArray(arr);
        }

        //public void swap(int s, int e)
        //{
        //
        //}

        public void showArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write("{0} ", i);
            }
        }

        public void pushInToArray(int val, int pushArrLen)
        {
            int[] inProcessArray = new int[pushArrLen + 1];
            for (int i = pushArrLen; i < pushArrLen + 1; i++)
            {
                inProcessArray[i] = val;
            }
        }
    }
}

