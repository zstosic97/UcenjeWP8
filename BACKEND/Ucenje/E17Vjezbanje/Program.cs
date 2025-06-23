﻿
namespace Ucenje.E17Vjezbanje
{
    public class Program
    {

        public Zadatak1 Zad1 { get; set; }

        public Program()
        {
            // zadatak konstruktora je konstruirati potrebvne zavisnosti
            Zad1 = new Zadatak1();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n*******************************");
            Console.WriteLine("*********** IZBORNIK ************");
            Console.WriteLine("0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            /*
                2. Izračun površine pravokutnika:
                    Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
                3. Provjera je li broj pozitivan, negativan ili nula:
                    Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
                4. Zbroj elemenata niza:
                    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
                5. Prosjek ocjena:
                    Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene. Program treba izračunati i ispisati prosjek ocjena.
                6. Ispis Fibonaccijevog niza:
                    Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
                7. Preokret stringa:
                    Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
                8. Brojanje samoglasnika:
                    Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
                9. Pretvorba temperature:
                    Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
                10. Sortiranje niza:
                    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
                11. Kalkulator:
                    Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.

             */
            Console.WriteLine("*******************************");
            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            int odabir = Pomocno.UcitajCijeliBroj("Unesi redni broj programa");
            switch (odabir)
            {
                case 0:
                    Console.WriteLine("Doviđenja!");
                    break;
                case 1:
                    Zad1.Izvedi();
                    //Console.WriteLine("1. zadatak");
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    break;
            }

            if (odabir != 0)
            {
                Izbornik();
            }




            // način 2
            /*
            switch(Pomocno.UcitajCijeliBroj("Unesi redni broj programa"))
            {
                case 0:
                    Console.WriteLine("Doviđenja!");
                    break;
                case 1:
                    // kreiranje instance klase Zadatak1
                    Console.WriteLine("1. zadatak");
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    Izbornik();
                    break;
            }
            */

        }
    }
}