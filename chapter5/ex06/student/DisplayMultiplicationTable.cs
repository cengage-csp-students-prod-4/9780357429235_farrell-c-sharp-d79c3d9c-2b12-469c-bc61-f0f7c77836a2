using System;
using static System.Console;
using System.Globalization;
class DisplayMultiplicationTable
{
	static void Main()
	{
	//Creates Header

		//top number
		Console.Write("  ");
		for (int num = 1; num < 11; num++){
			Console.Write($"  {num}");
		}

		//top lines
		Console.WriteLine();
		for (int i = 0; i < 33; i++)
		{
			Console.Write("-");
		}

		//side lines
		Console.WriteLine();
		for (int i = 0; i < 2; i++)
		{
			Console.Write("-");
		}


	//creates table
	
	Console.WriteLine();
	for (int multNum = 1; multNum < 11; multNum++)
	{
		Console.WriteLine("  ");
		Console.Write($"{multNum}  ");

		//mult table loop
		for (int num = 1; num < 11; num++)
			{
				Console.Write($"{multNum*num}  ");
			}

	}

	}
}