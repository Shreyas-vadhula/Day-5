using System;
public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 5, 8, 10, 76, 86, 97, 66 };
        Array.Sort(arr);
        Console.WriteLine(arr[(arr.Length - 2)]);

    }
}

