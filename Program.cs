using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 1, licznik2 = 1, licznik3 = 1;
            int[] liczniki = { 1, 1, 1 };
            string linia = string.Empty;
            while (linia != "exit")
            {
              
                linia = Console.ReadLine();
                switch (linia)
                {
                    case "A":
                        Console.WriteLine("A"+liczniki[0]++);
                        licznik++;
                        break;
                    case "B":
                        Console.WriteLine("B"+liczniki[1]++);
                        licznik++;
                        break;
                    case "C":
                        Console.WriteLine("C"+liczniki[2]++);
                        licznik++;
                        break;
                    default:
                        Console.WriteLine("Zly kod produktu");
                        break;
                }
                if (licznik>=20)
                {
                    Console.WriteLine("Koniec na dzis, ide grac w komputer");
                    break;
                } 
            }

            
            
            
            
            
            
            
            
            /*
            int licznik = 0;
            double suma = 0;
            double odleglosc = -1;
            while (odleglosc != 0)
            {
                string odlegloscTekst = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscTekst);
                suma += odleglosc;
                licznik++;
            }
            double wynik = (double)suma / (licznik-1);
            Console.WriteLine(wynik);
               













            Console.WriteLine("Podaj liczbę: ");
            string odpowiedz = Console.ReadLine();
            int liczba = Convert.ToInt32(odpowiedz);
            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");
            
            int liczba;
            bool czySieudalo = int.TryParse(odpowiedz, out liczba);
            if (czySieudalo)
            {
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Parzysta");
                }
                else
                {
                    Console.WriteLine("Nieparzysta");
                }
            }
            else
            {
                Console.WriteLine("Nie podano liczby");
            } */
        }
    }
}
