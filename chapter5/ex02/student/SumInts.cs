using System;
using static System.Console;
using System.Globalization;
class SumInts
{
	static void Main()
	{
		double userInt = 0;
		double total = 0;

		while (userInt != 999){
			Console.WriteLine("Enter a number please (enter 999 to end):");
			userInt = Convert.ToDouble(Console.ReadLine());
			total = userInt + total;
		
			if (userInt != 999){
			Console.WriteLine($"The total is {total}");
			}
		}
	}
}