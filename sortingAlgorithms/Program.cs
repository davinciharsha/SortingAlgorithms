using System;

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

            Console.WriteLine("1 - bubble sort, 2 - selection sort");

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
            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                if (arr[j] > arr[j+1])
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

        public void pushInToArray(int val,int pushArrLen)
        {
            int[] inProcessArray = new int[pushArrLen+1];
            for (int i = pushArrLen; i < pushArrLen+1; i++)
            {
                inProcessArray[i] = val;
            }
        }
    }
}

