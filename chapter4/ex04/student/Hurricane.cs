using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
	static void Main()
	{
		// windSpeed >= 157 = 5
		// 156 > windSpeed >= 130 = 4
		// 130 > windSpeed >= 111 = 3
		// 111 > windSpeed >= 96 = 2
		// 96 > windSpeed >= 74 = 1
		// 74 > windSpeed = none

		Console.WriteLine("What is the wind speed");
		double windSpeed = Convert.ToDouble(Console.ReadLine());

		if (windSpeed >= 157)
		{
			Console.WriteLine("This is a category 5 hurricane");
		}
		else if (windSpeed < 156 && windSpeed >= 130)
		{
			Console.WriteLine("This is a category 4 hurricane");
		}
		else if (130 > windSpeed && windSpeed >= 111)
		{
			Console.WriteLine("This is a category 3 hurricane");
		}
		else if (111 > windSpeed && windSpeed>= 96)
		{
			Console.WriteLine("This is a category 2 hurricane");
		}
		else if (96 > windSpeed && windSpeed >= 74)
		{
			Console.WriteLine("This is a category 1 hurricane");
		}
		else if (74 > windSpeed)
		{
			Console.WriteLine("This is not a hurricane");
		}


	}
}