using System;

class dhruvVaria
{
    private void moveZerotoEnd(int[] arr, int n)
    {
        printArray(arr, n);
        int zeroCnt = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroCnt++;
            }
            else if (zeroCnt > 0)
            {
                arr[i - zeroCnt] = arr[i];
                arr[i] = 0;
            }
        }
        printArray(arr, n);
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

        dhruvVaria dv = new dhruvVaria();
        dv.moveZerotoEnd(arr, n);
        
    }
}