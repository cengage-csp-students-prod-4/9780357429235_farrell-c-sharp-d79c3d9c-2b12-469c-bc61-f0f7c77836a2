using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
	static void Main()
	{
		Console.WriteLine("Enter your credit limit:");
		double userCredit = Convert.ToDouble(Console.ReadLine());


		if (userCredit > 8000)
		{
			Console.WriteLine("You have exceeded the credit limit");
		}
		else
		{
			Console.WriteLine("Approved");
		}
	}
}