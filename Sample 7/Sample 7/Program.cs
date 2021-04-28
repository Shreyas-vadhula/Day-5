using System;

namespace Sample_7
{    
    class Program
    {
        static void Main()
        {
            System.DateTime dob = new System.DateTime(1998, 03, 14);
            System.DateTime cdt = System.DateTime.Now;
            int Day = cdt.Day - dob.Day;
            int Month = cdt.Month - dob.Month;
            int Year = cdt.Year - dob.Year;
            Console.WriteLine(String.Format("Age: " + Math.Abs(Year) + " Year(s) " + Math.Abs(Month) + " Month(s) " + Math.Abs(Day) + " Day(s) "));
        }
    }
}
