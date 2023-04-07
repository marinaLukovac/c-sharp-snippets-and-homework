using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("======= zadatak 1 =======");
        Console.WriteLine("Uneti nastavnikovu zaradu: ");
        double zarada = 0.0;
        bool isZaradaValid = double.TryParse(Console.ReadLine(), out zarada);
        if (!isZaradaValid || zarada <= 0)
        {
            Console.WriteLine("Nije uneta validna vrednost zarade");
        }
        else
        {
            Console.WriteLine("Kojom su ocenom ucenici ocenili nastavnika?");
            int ocena = 0;
            bool isOcenaValid = int.TryParse(Console.ReadLine(), out ocena);
            if (!isOcenaValid || ocena < 1 || ocena > 10)
            {
                Console.WriteLine("Nije uneta validna vrednost ocene.");
            }
            else
            {
                string uspeh = "";
                string promenaPlate = "povecanje";
                double koeficijent = 1 + (double)ocena / 100;
                switch (ocena)
                {
                    case 1:
                    case 2:
                    case 3:
                        uspeh = "jako loš";
                        koeficijent = 0.85;
                        break;
                    case 4:
                    case 5:
                        uspeh = "proseèan";
                        break;
                    case 10:
                        uspeh = "izuzetan";
                        koeficijent = 1.15;
                        break;
                    default:
                        uspeh = "odlièan";
                        break;
                }

                promenaPlate = koeficijent < 1 ? "smanjenje" : "povecanje";
                double plataNakonOcenjivanja = koeficijent * zarada;
                Console.WriteLine("Nastavnik se medju studentima pokazao kao {0}, zbog cega se direktor odlucio na {1} zarade, sa {2}RSD na {3}RSD", uspeh, promenaPlate, zarada, plataNakonOcenjivanja);
            }
        }

        Console.WriteLine("======= zadatak 2 =======");
        Console.WriteLine("Uneti mesec u opsegu od 1 do 12: ");
        int mesec = 0;
        int brojDana = 0;
        string ispis = "GRESKA: Usled nepotpunog unosa podataka doslo je do neocekivanog prekida programa";
        var listaMeseci = new List<string>()
        {"", "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar"};
        bool isMesecValid = int.TryParse(Console.ReadLine(), out mesec);
        if (!isMesecValid || mesec < 1 || mesec > 12)
        {
            Console.WriteLine("Nije unet validan broj meseci");
        }
        else if (mesec == 2)
        {
            Console.WriteLine("Uneti godinu: ");
            int godina = 0;
            bool isGodinaValid = int.TryParse(Console.ReadLine(), out godina);
            if (!isGodinaValid || godina <= 0)
            {
                Console.WriteLine("Nije uneta validna vrednost za godinu!");
            }
            else
            {
                bool isPrestupna = (godina % 4 == 0 && godina % 100 != 0) || (godina % 400 == 0);
                brojDana = isPrestupna ? 29 : 28;
            }
        }
        else
        {
            switch (mesec)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    brojDana = 30;
                    break;
                default:
                    brojDana = 31;
                    break;
            }
        }

        if (brojDana != 0)
        {
            ispis = $"{listaMeseci[mesec]} ima {brojDana} " + (brojDana == 31 ? "dan." : "dana.");
        }

        Console.WriteLine(ispis);
    }
}