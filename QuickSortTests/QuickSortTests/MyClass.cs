using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    static void Sort(int[] arr, int l, int r)
    {
        int i = l;
        int j = r;
        int x = arr[(l + r) / 2];
        while (i <= j)
        {
            while (arr[i] < x) i++;
            while (arr[j] > x) j--;
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        if (l < j) Sort(arr, l, j);
        if (i < r) Sort(arr, i, r);
    }

    static void Main(string[] args)
    {
        int[] arr = new int[11];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rand.Next(-100, 100);
        foreach (int ar in arr)
            Console.WriteLine(ar + " ");
        Console.WriteLine("Сортировка");
        Sort(arr, 0, arr.Length - 1);
        foreach (int ar in arr)
            Console.WriteLine(ar + " ");
        Console.ReadLine();
    }
}