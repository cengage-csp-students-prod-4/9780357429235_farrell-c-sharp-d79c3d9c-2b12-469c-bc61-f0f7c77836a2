using System;
using static System.Console;
using System.Globalization;
class ArrayDemo
{
	enum Menu
	{
		IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
	}
	static void Main()
	{
		int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
		
		string userChoice = "The Future Is Bulletproof";

		while (userChoice != "4"){

			//ask user for choice
			Console.WriteLine("Do you want to read the list from first to last (1), last to first (2), look at a specific position (3), or quit (4): ");
			userChoice = Console.ReadLine();

			//first to last
			if (userChoice == "1"){
				for (int i = 0; i < 10; i++)
				{
					Console.Write(nums[i]);
				}
			}

			//last to first
			if (userChoice == "2"){
				for (int i = 9; i > -1; i--)
				{
					Console.Write(nums[i]);
				}
			}

			//user ask for pos.
			if (userChoice == "3"){
				Console.WriteLine("Which position would you like to look at: ");
				int userPos = Convert.ToInt16(Console.ReadLine());

				Console.WriteLine(nums[userPos]);
			}
		}
	}
}