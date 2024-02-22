using System;

class dhruvVaria
{
    private int binarySearch(int[] arr, int n, int target)
    {
        dhruvVaria chk = new dhruvVaria();
        if (chk.checkSorted(arr, n))
        {
            Console.WriteLine("Array is sorted.");
            int st = 0, en = n - 1;

            while(st < en)
            {
                int mid = (st + en) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target) { st = mid + 1;}
                else if (arr[mid] > target) {  en = mid - 1;}
            }
            Console.WriteLine("Element Not Found in Array ....");
        }
        else
        {
            Console.WriteLine("Array is not sorted. Binary Search Not Possible.......Soerting func will Come soon.....");
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

        dhruvVaria dv = new dhruvVaria();
        dv.printArray(arr, n);

        Console.WriteLine("\nEnter search Target : ");
        int target = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine($"Element {target} Found at position {dv.binarySearch(arr, n, target)} in Array.");

    }
}