// Create a function that takes two numbers as arguments and returns their sum.

using System;

class Program
{
	static void Main(string[] args)
	{
		int na, nb;
		MathOp mathOp = new MathOp();

		Console.WriteLine("Enter a number:");
		na = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number:");
                nb = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Result: " + mathOp.Sum(na, nb));
	}
}

class MathOp
{
	public int Sum(int a, int b)
	{
		return a + b;
	}
}
