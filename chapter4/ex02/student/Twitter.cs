using System;
using static System.Console;
using System.Globalization;
class Twitter
{
	static void Main()
	{
		Console.WriteLine("What is your Twitter message");
		string message = Console.ReadLine();

		//Console.WriteLine($"{message.Length}");

		if (message.Length > 140)
		{
			Console.WriteLine("The message is too long");
		}
		else
		{
			Console.WriteLine("The message is okay");
		}
	}
}