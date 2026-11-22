using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
	static void DisplayContactInfo()
	{
 		WriteLine("C# Company");
       WriteLine("Phone: 555-1234     Cell: 555-0912");
       WriteLine("Email: csharpcompany@csharp.com");
       WriteLine("On the Web at www.csharpcompanyforyou.com");
	}
	static void Main()
	{
		Console.WriteLine("From");
		Console.WriteLine("Dr. Deathify");
		DisplayContactInfo();

		Console.WriteLine("-----------------");
		Console.WriteLine("Dear Party Poison,");
		Console.WriteLine("Look alive, sunshine 109 in the sky, but the pigs won't quit You're here with me, Dr. Death-Defying I'll be your surgeon, your proctor Your helicopter Pumpin' out the slaughtermatic sounds to keep you alive A system failure for the masses Anti-matter for the master planLouder than God's revolver and twice as shiny This one's for all of you rock'n'rollers All you crash queens and motor babiesListen up");
		DisplayContactInfo();

		Console.WriteLine("**************");
		Console.WriteLine("Always remember the future is bulletproof");
		DisplayContactInfo();
	}
}