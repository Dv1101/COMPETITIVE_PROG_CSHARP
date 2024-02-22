using System;
using System.Runtime.InteropServices;

class dhruvVaria()
{

    private void removeDuplicates_usingSet(int[] arr, int n)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int i in arr)
        {
            set.Add(i);
        }
        Console.WriteLine("\nAfter removed Duplicates using set ......");
        Console.WriteLine(string.Join(", ", set));


    }

    private void removeDuplicates_usingIterative(int[] arr, int n)
    {
        if (n == 0 || n == 1)
            return;

        int i = 0;
        for (int j = 1; j < n; j++)
        {
            if (arr[i] != arr[j])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        Array.Resize(ref arr, i+1);

        Console.WriteLine("\nAfter removed Duplicates using iterative ......");
        foreach (int k in arr)
        {
            Console.Write($"{k}, ");
        }
    }


    public static void Main(String[] args)
    {

        Console.WriteLine("Enter size of array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("---------Enter " + n + " elements in array---------\n");
        for (int i = 0; i < n; i++)
        {
            //Console.WriteLine("Enter element " + (i + 1) + " in array");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        dhruvVaria dv = new dhruvVaria();
        dv.removeDuplicates_usingSet(arr, n);
        dv.removeDuplicates_usingIterative(arr, n);

    }
}