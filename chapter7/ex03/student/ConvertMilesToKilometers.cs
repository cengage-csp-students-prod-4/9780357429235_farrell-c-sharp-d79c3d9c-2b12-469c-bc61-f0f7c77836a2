using System;
using static System.Console;
using System.Globalization;
class ConvertMilesToKilometers
{
	const double MILE_TO_KM = 1.60934;
	static double ConvertToKilometers(double miles)
	{
		return miles*MILE_TO_KM;
	}
	static void Main()
	{
		Console.WriteLine("Enter the number of mile(s): ");
		double miles = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($" That is {ConvertToKilometers(miles)} Km");
	}
}