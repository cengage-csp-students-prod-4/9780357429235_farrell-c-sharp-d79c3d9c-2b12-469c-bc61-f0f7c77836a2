using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double CENTIMETERS_IN_A_INCH = 2.54;
		var inches = 3;

		Console.WriteLine($"{inches} inches is {inches*CENTIMETERS_IN_A_INCH} centimeters");
	}
}