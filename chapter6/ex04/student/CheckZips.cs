using System;
using static System.Console;
using System.Globalization;
class CheckZips
{
	static void Main()
	{
		string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
		
		bool match = false;


		Console.WriteLine("Where is your zip code: ");
		string userZip = Console.ReadLine();


		for (int i = 0; i < 10; i++)
		{
			if (userZip == zips[i])
			{
				match = true;
			}
		}

		if (match)
		{
			Console.WriteLine($"Delivery to {userZip} ok");
		}
		else
		{
			Console.WriteLine($"Sorry - no delivery to {userZip}");
		}

	}
}
