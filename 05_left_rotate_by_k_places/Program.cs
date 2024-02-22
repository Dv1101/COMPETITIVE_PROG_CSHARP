using System;

class dhruvVaria
{
    private void leftRotate(int[] arr, int n, int k)
    {
        printArray(arr, n);
        int[] ansArr = new int[n];
        int iterator = 0;
        for (int i = k; i < n; i++)
        {
            ansArr[iterator++] = arr[i];
        }
        for (int i = 0; i < k; i++)
        {
            ansArr[iterator++] = arr[i];
        }

        printArray(ansArr, n);
    }

    private void rightRotate(int[] arr, int n, int k)
    {
        printArray(arr, n);
        int[] ansArr = new int[n];
        int iterator = 0;

        for (int i = n - k; i < n; i++)
        {
            ansArr[iterator++] = arr[i];
        }
        for (int i = 0; i < n - k; i++)
        {
            ansArr[iterator++] = arr[i];
        }

        printArray(ansArr, n);
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
            //Console.WriteLine("Enter element " + (i + 1) + " in array");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter number of k places to rotate array : ");
        int k = Convert.ToInt32(Console.ReadLine());

        dhruvVaria dv = new dhruvVaria();
        dv.leftRotate(arr, n, k);
        dv.rightRotate(arr, n, k);
    }
}