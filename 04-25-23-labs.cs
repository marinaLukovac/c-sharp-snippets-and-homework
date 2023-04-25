using System;
using System.Text;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("----------------\tCalculate area of a triangle for the sides from 2 - 6\t----------------\n");
		for (int i = 2; i <= 6; i++)
		{
			double h = i + 1;
			double b = h;
			double c = h + 2;
			Console.WriteLine("\nSide value: {0} for the Equilateral triangle gives an area of: {1:N}.", i, CalculateTriangleArea(i));
			Console.WriteLine("\nBase value: {0} and height: {1} for the Isosceles triangle give an area of: {2:N}.", i, h, CalculateTriangleArea(i, h));
			double triangleArea = CalculateTriangleArea(i, b, c);
			bool areTriangleSides = triangleArea != 0;
			if (areTriangleSides)
			{
				Console.WriteLine("\nSides: {0}, {1} and {2} of a triangle, give an area of: {3:N}.\n-------\t-------\t-------\n", i, b, c, triangleArea);
			}
			else
			{
				Console.WriteLine("\nThis combo: {0}, {1}, {2}, cannot be a triangle.\nxxxxxxx\txxxxxxx\txxxxxxx\n", i, b, c);
			}
		}

		Console.WriteLine("\n--------------------\tWrite out 5 - 14 element of Fibonaci Series\t--------------------\n");
		for (int i = 5; i <= 14; i++)
		{
			Console.WriteLine("\n{0}. element of Fibonaci Series: {1}.", i, FibonaciSeries(i));
		}

		Console.WriteLine("\n\n----------------\tSum up variable amount of integers, multiplied by 2\t----------------\n");
		Console.WriteLine("\n 2 * ({0} + {1} + {2} + {3} + {4} + {5}) = {6}\n", 2, 3, 4, 5, 6, 70, SumTheNumbers(new int[]{2, 3, 4, 5, 6, 70}));
		Console.WriteLine("\n 2 * ({0} + {1} + {2} + {3}) = {4}\n", 1, 2, 3, 4, SumTheNumbers(1, 2, 3, 4)); //can pass params like this too
		Console.WriteLine("\n\n--------\tSum up even numbers, multiplied by 3, from variable amount of integers\t--------\n");
		Console.WriteLine("\nSum of even numbers from this group: {0}, {1}, {2}, {3}, {4}, {5} multiplied by 3 is {6}\n", 2, 3, 4, 5, 6, 70, SumTheEvenNumbers(new int[]{2, 3, 4, 5, 6, 70}));
		Console.WriteLine("\nSum of even numbers from this group: {0}, {1}, {2}, {3} multiplied by 3 is {4}\n", 1, 2, 3, 4, SumTheEvenNumbers(1, 2, 3, 4));
	}

	public static double CalculateTriangleArea(double a)
	{
		return (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
	}

	public static double CalculateTriangleArea(double a, double h)
	{
		return (a * h) / 2;
	}

	public static double CalculateTriangleArea(double a, double b, double c)
	{
		double semiPerimeter = (a + b + c) / 2;
		return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
	}

	public static int FibonaciSeries(int n)
	{
		List<int> fibonaciFocus = new List<int>{0, 1, 1, 2};
		for (int i = 4; i <= n; i++)
		{
			fibonaciFocus.Add(fibonaciFocus[i - 2] + fibonaciFocus[i - 1]);
		}

		return fibonaciFocus[n - 1];
	/* Another option:
		int previousElement = 1;
		int currentElement = 2;
		int element;
		for (int i = 5; i <= n; i++)
		{
			element = currentElement + previousElement;
			previousElement = currentElement;
			currentElement = element;
		}	
			return currentElement;
	*/
	}

	public static int SumTheNumbers(params int[] numbers)
	{
		int sum = 0;
		foreach (int number in numbers)
		{
			sum += number * 2;
		}

		return sum;
	}

	public static int SumTheEvenNumbers(params int[] numbers)
	{
		int sum = 0;
		foreach (int number in numbers)
		{
			if (number % 2 == 0)
			{
				sum += number * 3;
			}
		}

		return sum;
	}
}