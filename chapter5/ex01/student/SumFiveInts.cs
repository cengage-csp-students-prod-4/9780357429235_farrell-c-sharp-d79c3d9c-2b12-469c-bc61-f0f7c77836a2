using System;
using static System.Console;
using System.Globalization;
using System.Runtime.CompilerServices;
class SumFiveInts
{
	static void Main()
	{
		double total = 0;


		for(int i = 0; i < 5; i++){
			Console.WriteLine("Please enter a interger");
			double userInt = Convert.ToDouble(Console.ReadLine());
		
			total = total + userInt;
		}
		
		
		Console.WriteLine($"The sum is {total}");
	}
}