using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		for (int i = 1; i <= 100; i++)
		{
			Console.WriteLine("For the number {0}, corresponding pentagonal number is: {1}", i, PentagonalNumber(i));
		}

		Console.WriteLine("\n===========\tDraw a matrix of random numbers from 10 - 100:\t===========\n\nEnter number of rows for the matrix");
		int rows = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number of columns for the matrix");
		int cols = int.Parse(Console.ReadLine());
		Console.Write("\n\n===========\t {0} x {1} \t===========\n", rows, cols);
		DrawMatrix(rows, cols);
		Console.Write("\n\n===========\t {0} x {0} \t===========\n", rows);
		DrawMatrix(rows);
		Console.WriteLine("\n\n===================\tConvert Celsius to Farenheit- vice versa\t===================\n");
		for (int i = 20; i <= 50; i++)
		{
			Console.WriteLine("{0} degrees Celsius equals to {1:N} farenheit", i, CelsiusToFarenheit(i));
		//Console.WriteLine
		}

		Console.WriteLine("\n===================\n");
		for (int i = 50; i <= 80; i++)
		{
			Console.WriteLine("{0} degrees Farenheit equals to {1:N} celsius", i, FarenheitToCelsius(i));
		}

		Console.WriteLine("\n===================\tUsing String Builder object class\t===================\n");
		Console.WriteLine("\nWritten 3x hello using space: \n\n{0}", Repeat("hello", 3));
		Console.WriteLine("\nWritten 10x hello using space, but every 3rd make new line: \n\n{0}", Repeat("hello", 10, 3)); //second method
		Console.WriteLine("\n===================\tfirst letter capital\t===================\n");
		Console.WriteLine(FormatStringToFirstUpperCase("proGraMIranje"));
	}

	public static double PentagonalNumber(int number)
	{
		double result = (number * ((3 * number) - 1)) / 2;
		return result;
	}

	public static int ReverseNumber(int number)
	{
		char[] arrayOfNumbers = number.ToString().ToCharArray();
		Array.Reverse(arrayOfNumbers);
		//string reversedText = arrayOfNumbers.ToString();
		//int reversedNumber = int.Parse(reversedText);
		return int.Parse(new string (arrayOfNumbers));
	//return reversedNumber;
	}

	public static void DrawMatrix(int row, int col)
	{
		Random rnd = new Random();
		for (int i = 0; i < row; i++)
		{
			Console.WriteLine("\n");
			for (int j = 0; j < col; j++)
			{
				Console.Write("{0} ", rnd.Next(90) + 10); // same as rnd.Next(10,100)
			}
		}
	}

	public static void DrawMatrix(int n)
	{
		Random rnd = new Random();
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("\n");
			for (int j = 0; j < n; j++)
			{
				Console.Write("{0} ", rnd.Next(90) + 10); // same as rnd.Next(10,100)
			}
		}
	}

	public static double CelsiusToFarenheit(double celsius)
	{
		// 20 -50
		// 9/5  * celzijusi + 32
		// 5/ 9  * farenhajti - 32 // zaokruzi na 2 decimale
		// "{0:N}" String za formatiranje
		// string.Format("{0,N}",number); ==> used for all kinds of formats date, time, etc
		return ((9.0 / 5) * celsius + 32);
	}

	public static double FarenheitToCelsius(double farenheit)
	{
		// 
		// 9/5  * celzijusi + 32
		// 5/ 9  * farenhajti - 32 // zaokruzi na 2 decimale
		// "{0:N}" String za formatiranje
		return ((5.0 / 9) * farenheit - 32);
	}

	// public static string Repeat(string s, int n) //nikad vece od duzine reci s.Length //vraca broj karaktera koji se nalaze u stringu
	// {
	// 	StringBuilder b = new StringBuilder(n * s.Length); //if no value is passed here, then it might take much more memory space than it should
	// 	// rad sa stringom pomocu objekta koji je brzi, moze da koristi razne metode praveci da taj string objekat bude mutable... 
	// 	// StringBuilder je klasa koja se uvozi iz System.Text namespace-a
	// 	for (int i = 0; i < n; i++)
	// 	{
	// 		b.Append(s);
	// 	}
	// 	return b.ToString();
	// }
	public static string Repeat(string s, int n) //nikad vece od duzine reci s.Length //vraca broj karaktera koji se nalaze u stringu
	{
		StringBuilder b = new StringBuilder(n * (s + " ").Length); //if no value is passed here, then it might take much more memory space than it should
		// rad sa stringom pomocu objekta koji je brzi, moze da koristi razne metode praveci da taj string objekat bude mutable... 
		// StringBuilder je klasa koja se uvozi iz System.Text namespace-a
		for (int i = 0; i < n; i++)
		{
			b.Append(s + " ");
		}

		return b.ToString();
	}

	public static string Repeat(string s, int n, int m) //nikad vece od duzine reci s.Length //vraca broj karaktera koji se nalaze u stringu
	{
		StringBuilder b = new StringBuilder(n * (s + " ").Length); //if no value is passed here, then it might take much more memory space than it should
		// rad sa stringom pomocu objekta koji je brzi, moze da koristi razne metode praveci da taj string objekat bude mutable... 
		// StringBuilder je klasa koja se uvozi iz System.Text namespace-a
		for (int i = 1; i <= n; i++)
		{
			if (i % m == 0)
			{
				b.Append(s + "\n");
			}
			else
			{
				b.Append(s + " ");
			}
		}

		return b.ToString();
	}

	public static string FormatStringToFirstUpperCase(string text) //nikad vece od duzine reci s.Length //vraca broj karaktera koji se nalaze u stringu
	{
		char[] arrOfChars = text.ToCharArray();
		for (int i = 0; i < arrOfChars.Length; i++)
		{
			if (i == 0)
			{
				arrOfChars[i] = Char.ToUpper(arrOfChars[i]);
			}
			else
			{
				arrOfChars[i] = Char.ToLower(arrOfChars[i]);
			}
		}

		return new string (arrOfChars);
	}
}