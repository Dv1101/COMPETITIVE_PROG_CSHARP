using System;
using System.Runtime.InteropServices;

class dhruvVaria() {
    
    bool checkSorted(int[] arr, int n)
    {
        if(n < 2)
        {
            Console.WriteLine("ONLY ONE ELEMENT.....");
            return true;
        }

        for(int i = 0; i<n-1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }


        return true;
    }



    public static void Main(String[] args) {

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
        if(dv.checkSorted(arr, n))
        {
            Console.WriteLine("Array is sorted." );
        }
        else
        {
            Console.WriteLine("Array is not sorted.");
        }
        
    }
}