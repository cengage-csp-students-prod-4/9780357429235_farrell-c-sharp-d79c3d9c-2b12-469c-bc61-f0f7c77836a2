using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
class PaintingEstimate
{
	const double HIEGHT = 9;
	const double PRICE_PER_SQFT = 6;

	static double PriceEstimate(double length, double width)
	{
		return (2*(length*HIEGHT) + 2*(width*HIEGHT) + (length*width))*PRICE_PER_SQFT;
	}
	static void Main()
	{
		Console.WriteLine("Enter length of the room in feet >>");
		double length = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Enter width of the room in feet >>");
		double width = Convert.ToDouble(Console.ReadLine());
		

		Console.WriteLine($"Cost of job for {length} X {width} foot room is {PriceEstimate(length, width):C}");
	
	}
}