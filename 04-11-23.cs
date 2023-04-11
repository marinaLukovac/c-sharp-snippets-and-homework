using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		{ // ======== Char klasa - metode ===========
			Console.WriteLine("Da li je broj? " + Char.IsDigit(karakter));
			Console.WriteLine("Da li je slovo? " + Char.IsLetter('S'));
			Console.WriteLine("Da li je veliko slovo? " + Char.IsUpper('T'));
			Console.WriteLine("Prebaci u veliko slovo: " + Char.ToUpper('b'));
		}
		
    { // ======== WHILE =======
			//Petlje: 
			
      { // ispis brojeva 4-10
        int brojac = 4;
        while(brojac<=10)
        {
          Console.WriteLine("Brojimo sitno: {0}",brojac);
          brojac++;
        }
      }
      
      { // Primer: racunanje maksimuma unetih brojeva
        Console.WriteLine("Unesite brojeve koje zelite da saberete. Kada izaberete nulu, program se zavrsava.");
        Console.WriteLine("Unesite prvi broj: ");
        int broj = int.Parse(Console.ReadLine());
        int suma = 0;

        while (broj != 0)
        {
          suma += broj;
          Console.WriteLine("Unesite sledeci broj: ");
          broj = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Suma unetih brojeva je: " +suma);
      }
      
      { // ispis u jednoj liniji brojeva od 0 do 9
        int broj = 0;
        while (broj <= 9)
        {
          Console.Write(broj + " ");
          broj++;
        }
      }

      { // wRITE NUMBERS 1 TO 5
        int brojac = 1;
        while (brojac <= 5)
        {
          Console.WriteLine("Brojac je: " + brojac);
          brojac++;
        }

        Console.WriteLine("Izasli smo iz petlje.");
      }

      { // guessing game: WHILE
        Random rnd = new Random();
        int br = rnd.Next(1, 101);
        bool pogodak = false;
        Console.WriteLine("Unesite celi broj izmedju 1 i 100");
        while (!pogodak)
        {
          int broj = 0;
          bool isBrojValid = int.TryParse(Console.ReadLine(), out broj);
          while (!isBrojValid || broj < 1 || broj > 100)
          {
            Console.WriteLine("Nije unet pravilan broj, pokusajte ponovo: ");
            isBrojValid = int.TryParse(Console.ReadLine(), out broj);
          }

          if (broj < br)
          {
            Console.WriteLine("Broj {0} je manji od tajnog broja, pokusajte ponovo!", broj);
          }
          else if (broj > br)
          {
            Console.WriteLine("Broj {0} je veci od tajnog broja, pokusajte ponovo!", broj);
          }
          else
          {
            pogodak = true;
            Console.WriteLine("Broj {0} je isti kao i tajni broj {1}, igra je gotova!", broj, br);
          }
        }
      }

      { // guessing game DO-WHILE
        Random rnd = new Random();
        int tajniBroj = rnd.Next(1, 101);
        int pokusajBroja;
        Console.WriteLine("Uneti broj");
        do
        {
          pokusajBroja = int.Parse(Console.ReadLine());

          if (pokusajBroja < tajniBroj)
          {
            Console.WriteLine("Broj {0} je manji od tajnog broja, pokusajte ponovo!", pokusajBroja);
          }
          else if (pokusajBroja > tajniBroj)
          {
            Console.WriteLine("Broj {0} je veci od tajnog broja, pokusajte ponovo!", pokusajBroja);
          }
          else
          {
            Console.WriteLine("Broj {0} je isti kao i tajni broj {1}, igra je gotova!", pokusajBroja, tajniBroj);
          }
        } while ( tajniBroj != pokusajBroja);
      
      }

      { // wRITE NUMBERS 1 TO 10
        int broj = 1;
        do
        {
          Console.Write(broj + " ");
          broj++;
        } while (broj <= 10);
      }
      
      { //improved guessing game: DYNAMIC MIN AND MAX, NUMBER OF ATEMPTS AND INPUT VALIDATION
        Console.WriteLine("Let's play a guessing game!\nEnter minimum and maximum guessing values\nThose should be whole numbers:");
        int min;
        int max;
        //add validation for min and max
        bool isMinValid = int.TryParse(Console.ReadLine(),out min);
        while (!isMinValid)
        {
          Console.WriteLine("Please enter valid whole number: ");
          isMinValid = int.TryParse(Console.ReadLine(), out min);
        }
        bool isMaxValid = int.TryParse(Console.ReadLine(),out max);
        while (!isMaxValid)
        {
          Console.WriteLine("Please enter valid whole number: ");
          isMaxValid = int.TryParse(Console.ReadLine(), out max);
        }

        if (min > max)
        {
          (max, min) = (min, max);
        }


        Random rnd = new Random();
        int tajniBroj = rnd.Next(min, max);
        int pokusajBroja;
        int brojPokusaja = 0;
        Console.WriteLine("Thank you. Now guess what number did I choose:");
        // bool isPokusajValid = false;
        do
        {
          bool isBrojValid = int.TryParse(Console.ReadLine(), out pokusajBroja);
          while (!isBrojValid || pokusajBroja < min || pokusajBroja > max)
          {
            Console.WriteLine("Please enter valid value, whole number from {0} to {1}: ",min,max);
            isBrojValid = int.TryParse(Console.ReadLine(), out pokusajBroja);
          }
          brojPokusaja++;
          if (pokusajBroja == tajniBroj)
          {
            Console.WriteLine("Number {0} equals to {1}, the game is over, you guessed in {2}. attempt, you {3}!", pokusajBroja, tajniBroj, brojPokusaja, brojPokusaja < 10 ? "won" : "lost");
          }
          else
          {
            Console.WriteLine("Number {0} is {1} than the secret number, try again!", pokusajBroja, pokusajBroja>tajniBroj ? "larger":"smaller");
          }
        } while (tajniBroj != pokusajBroja);

      }
		}
	}
}