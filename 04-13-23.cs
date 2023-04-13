using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{ //FOR loop
		{ // {} can be left out from the for loop
			for (int i = 0; i <= 5; i++) Console.Write(i + " ");
		}
		{ // CTRL + F5 ==> shortcut to run the program without degugging
			for(int i = 0; i<10; i++) Console.Write(i + " ");
		}
		{
			int i = 0;
			for(;;) // this is also possible but will run infinitely if break is not given
			{
				if(i < 5)
				{

					Console.Write(i);
					i++; 
				}
				else
				{
					break;
				}
			}
		}
		{
			Console.WriteLine("Enter whole number: ");
			int n = int.Parse(Console.ReadLine());
			int k;
			for (k = 1; k < n; k++) Console.WriteLine("value k is: " + k);
			Console.WriteLine("Loop is done. The last k value was: " + (k-1));
		}
		{   // task: translate for into while
			int sum = 0;
			for(int count=0; count<=5; count++)
			{
				sum += count;
				Console.WriteLine(count + " ");
			}
			Console.WriteLine("Sum is: " + sum);
		}
		{
			Console.WriteLine("Program counts natural logarithm ln(x) for numbers from 0.1 to 2.0");
			for(double counter = 0.1; counter<=2.0; counter=counter+0.1)
			{
				Console.WriteLine("Natural algorithm of number {0} is: {1}.",counter, Math.Log2(counter));
			}
		}
		{
			Console.WriteLine("Enter whole number n: ");
			int n = int.Parse(Console.ReadLine());
			bool isPrime = true;
			var maxDivider = (int)Math.Sqrt(n); // Math.Sqrt always returns double
												// number 1 is excluded because number is prime if it is dividable by itself and 1
			for (int number = 2; number <= maxDivider; number++)
			{
				if (n % number == 0)
				{
					isPrime = false;
					break;
				}
			}
			Console.WriteLine("Number {0} is{1} prime.", n, isPrime ? "" : " not");
		}
		{
			int[] arrayOfNumbers = { 2, 4, 5, 7, 8, 9, 10 };
			int sum = 0;
			foreach(int i in arrayOfNumbers)
			{
				sum += i;
			}
			Console.WriteLine("Sum of numbers " + sum);
		}
		{ // Convert miles to kilometers 
			Console.WriteLine("\n\nMiles \t| Kilometers");
			Console.WriteLine("====================");
			for (int i = 1; i<=10; i++)
			{
				Console.WriteLine("{0} \t| {1} ", Math.Round(i * 1.601, 2), i);
				Console.WriteLine("--------------------");
			}
			Console.WriteLine("\n\n");
		}
		{ // Environment.Exit(0); // exit code completely (not such a good practice) : (keep the loop simple)

		}
  }
}