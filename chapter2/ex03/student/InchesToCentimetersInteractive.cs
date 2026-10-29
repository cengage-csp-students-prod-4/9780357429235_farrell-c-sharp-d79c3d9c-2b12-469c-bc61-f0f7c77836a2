using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double CENTIMETERS_IN_A_INCH = 2.54;

		Console.WriteLine("Enter the measurment in inches: ");
		int inches = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"{inches} inches is {inches*CENTIMETERS_IN_A_INCH} centimeters");
	}
}