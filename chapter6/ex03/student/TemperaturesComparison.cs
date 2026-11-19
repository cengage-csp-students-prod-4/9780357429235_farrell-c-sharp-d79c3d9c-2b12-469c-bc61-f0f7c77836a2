using System;
using static System.Console;
using System.Globalization;
using System.Collections.Generic;

class TemperaturesComparison
{
	static void Main()
	{
		int run = 0;
		double userTemp;
		List<double> temp = new List<double>();


		//gets the temps
		while (run < 5)
		{
			Console.WriteLine("Please enter a number between -30 through 130: ");
			userTemp = Convert.ToDouble(Console.ReadLine());

			if (userTemp >= -30 && userTemp <= 130)
			{
				temp.Add(userTemp);
				run++;
			}

			else
			{
				Console.WriteLine("Please enter another value");
			}

		}


		//checks if it's warmer, colder, or mixed
		
		//warm
		if (temp[0] < temp[1] && temp[1] < temp[2] && temp[2] < temp[3] && temp[3] < temp[4])
		{
			Console.Write("Getting warmer: ");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(temp[i]);
				Console.Write(" ");
			}
		}

		//cold
		else if (temp[0] > temp[1] && temp[1] > temp[2] && temp[2] > temp[3] && temp[3] > temp[4])
		{
			Console.Write("Getting cooler: ");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(temp[i]);
				Console.Write(" ");
			}
		}

		//mixed
		else
		{
			Console.Write("It's a mixed bag: ");
			for (int i = 0; i < 5; i++)
			{
				Console.Write(temp[i]);
				Console.Write(" ");
			}
		}

		//average
		Console.WriteLine();
		Console.Write($"Average: {(temp[0] + temp[1] + temp[2] + temp[3] + temp[4])/5}" );

	}
}