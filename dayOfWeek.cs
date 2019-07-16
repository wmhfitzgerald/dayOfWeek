using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DayOfWeek
{
	public class Program
	{
		public string Source(string inDay, int inDayNum)
		{
			int dayNum = 0;
			DayOfWeek day;
			for (int i = 0; i < 7; i++)
			{
				day = (DayOfWeek) ((i) %7);
				string f = day.ToString().Substring(0,3);
				if (f == inDay)
				{
					dayNum = i + inDayNum;
				}
			}			
			day = (DayOfWeek) ((dayNum) %7);
			return day.ToString();
		}

		public static void Main()
		{
			Program p = new Program();
			string s = p.Source("Tue", 18);
			Console.WriteLine("Your day is " + s);
		}
	}
}
