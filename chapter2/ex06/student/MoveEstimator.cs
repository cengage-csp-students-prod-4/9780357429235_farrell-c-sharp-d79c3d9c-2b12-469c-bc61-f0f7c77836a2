using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double BASE_RATE_PER_MOVE = 200;
		const double HOUR_RATE = 150;
		const double MILE_RATE = 2;		
		
		//hour
		Console.WriteLine("How long will we be there: ");
		int hours = Convert.ToInt32(Console.ReadLine());

		//miles
		Console.WriteLine("How many miles will we travel: ");
		int miles = Convert.ToInt32(Console.ReadLine());


		Console.WriteLine($"For a move taking {hours} hours and going {miles} miles the estimate is {(BASE_RATE_PER_MOVE)+(HOUR_RATE*hours)+(MILE_RATE*miles)}");
	
	}
}