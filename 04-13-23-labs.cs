using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		{
			Console.WriteLine("\n==============\t1.\t==============\n");
			Console.WriteLine("Enter number greater than 0: ");
			double number;
			bool isNumberValid = double.TryParse(Console.ReadLine(), out number);
			while (!isNumberValid || number <= 0)
			{
				Console.WriteLine("Please enter valid number: ");
				isNumberValid = double.TryParse(Console.ReadLine(), out number);
			}

			double y = (Math.Pow(number, 3) - 4) / (Math.Sqrt(Math.Ceiling(5 * number)));
			Console.WriteLine("\nFor the entered number: {0}, the result for given equation is: {1}", number, y);
		}

		{
			Console.WriteLine("\n==============\t2.\t==============\n");
			Console.WriteLine("Enter one of next values: \"pow\", \"round\", \"floor\" or \"ceiling\":");
			string operation = Console.ReadLine()?.ToLower() ?? "";
			// because of these operaters ?. ?? Compiler had to be of .NET 7 once more
			var operations = new List<String>()
			{"pow", "round", "floor", "ceiling"};
			while (!operations.Contains(operation))
			{
				Console.WriteLine("Please enter valid value:");
				operation = Console.ReadLine()?.ToLower() ?? "";
			}

			Console.WriteLine("Enter real number, with decimal spaces: ");
			double number;
			bool isNumberValid = double.TryParse(Console.ReadLine(), out number);
			while (!isNumberValid)
			{
				Console.WriteLine("Please enter valid number:");
				isNumberValid = double.TryParse(Console.ReadLine(), out number);
			}

			double result;
			switch (operation)
			{
				case "round":
					result = Math.Round(number);
					break;
				case "floor":
					result = Math.Floor(number);
					break;
				case "ceiling":
					result = Math.Ceiling(number);
					break;
				default:
					Console.WriteLine("Enter exponent\nCRITERIA: positive | whole | number: ");
					int exponent;
					bool isExponentValid = int.TryParse(Console.ReadLine(), out exponent);
					while (!isExponentValid || exponent <= 0)
					{
						Console.WriteLine("Please enter valid number:");
						isExponentValid = int.TryParse(Console.ReadLine(), out exponent);
					}

					result = Math.Pow(number, exponent);
					break;
			}

			Console.WriteLine("\nThe result for {0} operation, for the entered value {1} is: {2}", operation, number, result);
		}

		{
			Console.WriteLine("\n==============\t3.\t==============\n");
			Console.WriteLine("Enter positive number: ");
			double number;
			bool isNumberValid = double.TryParse(Console.ReadLine(), out number);
			while (!isNumberValid || number <= 0)
			{
				Console.WriteLine("Please enter valid number: ");
				isNumberValid = double.TryParse(Console.ReadLine(), out number);
			}

			double x1 = (Math.Pow(number, 3) - 4) / (Math.Sqrt(Math.Floor(5 * number)));
			double x2 = (Math.Pow(number, 3) - 5 * Math.Pow(number, 2) - 6 * number + 2) / (Math.Sqrt(2 * number));
			double result = (x1 * x2) / Math.Sqrt(number);
			Console.WriteLine("\nEntered number is: {0}\n\nx1: {1}\n\nx2: {2}\n\nresult: {3}", number, x1, x2, result);
		}

		{ // write 10 random characters with capital first letter
			// random.next(x,y) ==> [ x , y ) inclusive lower and exclusive upper,
			// upper must be greater or equal to lower
			Console.WriteLine("\n==============\t4.\t==============\n");
			Random rnd = new Random();
			string randomized = "";
			for (int i = 1; i <= 10; i++)
			{
				randomized += (i == 1 ? ((char)rnd.Next(65, 91)) : ((char)rnd.Next(97, 123)));
			}

			Console.WriteLine("Randomized 10-character string is \"{0}\"\n\nThank you for your attention, have a nice holiday!\n", randomized);
			Console.WriteLine("=============\tEND\t==============");
		}
	}
}