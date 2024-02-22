using System;

class dhruvVaria
{
    public int largest(int[] arr)
    {
        int i;

        int max = arr[0];

        for (i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];

        return max;
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
        Console.WriteLine("Largest in given array is " + dv.largest(arr));
    }
}
