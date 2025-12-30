// Write a function that takes an integer minutes and converts it to seconds.

using System;
using static System.Console;

class Program
{
	static void Main(string[] args)
	{
		int min;
		TimeOp timeOp = new TimeOp();

		WriteLine("Enter the amount of minutes:");
		min = Convert.ToInt32(ReadLine());
		timeOp.MinToSec(min);
	}
}

class TimeOp
{
	public void MinToSec(int min)
	{
		WriteLine("Seconds: " + (min * 60));
	}
}
