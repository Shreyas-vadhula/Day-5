using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string");
        String str = Console.ReadLine();
        int len = str.Length;
        int temp = 0;         
        String[] arr = new String[len * (len + 1) / 2];         
        for (int i = 0; i < len; i++)
        {            
            for (int j = 0; j < len - i; j++)
            {
                arr[temp] = str.Substring(i, j + 1);
                temp++;
            }
        }          
        Console.WriteLine("All subsets for given string are : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}