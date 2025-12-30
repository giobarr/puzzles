// Create a function that takes a number as an argument, increments the number by +1 and returns the result.

using System;

class Program
{
	static void Main(string[] args)
	{
		int na;
		ShortIO s = new ShortIO();
		Program p = new Program();

		s.W("Type a number:");
		na = Convert.ToInt32(s.R());

		s.W("The next number is: " + p.Next(na));	
	}

	int Next(int a)
	{
		return a + 1;
	}
}

class ShortIO
{
	public string R()
	{
		string temp = Console.ReadLine();
		return temp;
	}

	public void W(string temp)
	{
		Console.WriteLine(temp);
	}
}
