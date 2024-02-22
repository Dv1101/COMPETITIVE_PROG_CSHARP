using System;
using System.Collections.Immutable;

class dhruvVaria
{
    private int unionSortedArrays(int[] arr, int[] arr2, int n, int m)
    {
        dhruvVaria chk = new dhruvVaria();
        if (chk.checkSorted(arr, n) && chk.checkSorted(arr2, m))
        {
            Console.WriteLine("Array is sorted.");
            HashSet<int> distinctSet = new HashSet<int>();

            foreach (int i in arr)
            {
                distinctSet.Add(i);
            }
            foreach (int i in arr2)
            {
                distinctSet.Add(i);
            }

            List<int> sortedList = distinctSet.OrderBy(i => i).ToList();

            Console.WriteLine("Union of Arrays : ");
            foreach (int i in sortedList)
            {
                Console.Write($"{i}, ");
            }

        }
        else
        {
            Console.WriteLine("Array is not sorted. Union Not Possible.......Sorting function will come soon.....");
            arr = arr.OrderBy(i => i).ToArray();
            arr2 = arr2.OrderBy(i => i).ToArray();
            return unionSortedArrays(arr, arr2, n, m);
        }

        return 0;
    }


    bool checkSorted(int[] arr, int n)
    {
        if (n < 2)
        {
            Console.WriteLine("ONLY ONE ELEMENT.....");
            return true;
        }

        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }


        return true;
    }

    private void printArray(int[] arr, int n)
    {
        Console.WriteLine("\n------ ARRAY IS ------\n");
        foreach (int i in arr) Console.Write($"{i},");
    }

    public static void Main()
    {
        Console.WriteLine("Enter size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("---------Enter " + n + " elements in array---------\n");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + " in array");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter size of array 2 : ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[m];

        Console.WriteLine("---------Enter " + n + " elements in array 2---------\n");
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + " in array 2");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        dhruvVaria dv = new dhruvVaria();
        dv.printArray(arr, n);

        dv.unionSortedArrays(arr, arr2, n, m);

    }
}