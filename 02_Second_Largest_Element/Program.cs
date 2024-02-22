using System;

class dhruvVaria
{

    public int secondLargest_usingTwoPass(int[] arr, int n)
    {

        if (n < 2)
        {
            Console.WriteLine("Second largest element not available as array is small sized !!!");
            return -1;
        }

        int max = int.MinValue;
        int maxSec = int.MinValue;

        foreach (int i in arr)
        {
            max = Math.Max(max, i);
        }

        foreach (int i in arr)
        {
            if (i != max)
            {
                maxSec = Math.Max(maxSec, i);
            }
        }

        return maxSec;
    }


    public int secondLargest_usingSort(int[] arr, int n)
    {

        if (n < 2)
        {
            Console.WriteLine("Second largest element not available as array is small sized !!!");
            return -1;
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        return arr[1];
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

        dhruvVaria dv = new dhruvVaria();
        Console.WriteLine("Second Largest in given array is " + dv.secondLargest_usingSort(arr, n));
    }
}
