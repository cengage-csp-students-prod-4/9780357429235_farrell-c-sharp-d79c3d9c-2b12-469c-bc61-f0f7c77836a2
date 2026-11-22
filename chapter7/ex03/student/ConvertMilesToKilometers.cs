using System;
using static System.Console;
using System.Globalization;
class ConvertMilesToKilometers
{
	static double ConvertToKilometers(double miles)
	{
		const double MILE_TO_KM = 1.60934;
		return miles*MILE_TO_KM;
	}
	static void Main()
	{
		Console.WriteLine("Enter the number of mile(s): ");
		double miles = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine($" That is {ConvertToKilometers(miles)} Km");
	}
}