
using System;
namespace Sample6
{

	public class Example2
	{
		public static void Main()
		{
			System.DateTime datetime = DateTime.Now;
			Console.WriteLine("Today's date is = " + datetime.Date);
			Console.WriteLine("Today's time is = " + datetime.TimeOfDay);
			Console.WriteLine("The year is = " + datetime.Year);
			Console.WriteLine("The month is = " + datetime.Month);
			Console.WriteLine("The day is = " + datetime.Day);
			Console.WriteLine("The hour is = " + datetime.Hour);
			Console.WriteLine("The minute is = " + datetime.Minute);
			Console.WriteLine("The second is = " + datetime.Second);
			Console.WriteLine("The millisecond is = " + datetime.Millisecond);
			Console.ReadLine();
;		}
	}

}

