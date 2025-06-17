

using System.Buffers;
using System.Security.Cryptography.X509Certificates;

namespace Ucenje.E14KlasaObjekt
{
    internal class Program
    {
        // 5. vrsta metode je konstruktor
        // Naziv mora bit ijednak nazivu klase
        public Program()
        {
            Console.WriteLine("Klasa/Objekt");

            // Objekt je pojavnost (instanca) klase -----> ovo naučiti napamet


            // Osoba (primjetiti veliko slovo O) je klasa
            // osoba (primjetiti malo slovo o) je objekt (instanca, varijabla)
            Osoba osoba = new Osoba();  // pozvali smo konstruktor od klase Osoba (new)

            // postavljanje vrijednosti ta svojstva objekta
            osoba.Sifra = 1; // pozvao si setter (učahurivanje)
            //osoba.Ime = "Pero"; namjerno ime ostavljamo null jer ono može biti null (? smo stavili)
                osoba.Prezime = "Perić";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);



            // ponoviti ću s uzimanjem vrijednosti od naših korisnika
            osoba.Sifra = Pomocno.ucitajCijeliBroj("Unesi šifru osobe"); // usporediti s linijom 20 
            osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            osoba.DatumRodenja = new DateTime(
                Pomocno.ucitajCijeliBroj("Unesi godinu rođenja"),
                Pomocno.ucitajCijeliBroj("Unesi mjesec rođenja"),
                Pomocno.ucitajCijeliBroj("Unesi dan rođenja")
                );


            // Korištenje virjednosti svojstava
            Console.WriteLine(osoba.Prezime); // pozvao si getter (učahurivanje)

            Console.WriteLine(osoba.Ime??""); // ime može biti null, stoga ?? znači što će biti ako je null. Konkretno ko je ima null, ispiši prazno


            // ne statična metoda se zove s objekta 
            osoba.IspisiImeIPrezime();

            Osoba[] osobe = new Osoba[3];

            // skraćeni oblik postavljanja vrijednosti svojstava
            osobe[0] = new Osoba() {
                Ime = "Marija",
                Prezime = "Kat",
                Sifra = 2,
                DatumRodenja = new DateTime(1982, 1, 2)
            };

            osobe[1] = new() { Ime = "Ante" };

            osobe[2] = osoba; 

            foreach(Osoba o in osobe)
                {
                Console.WriteLine(o.Ime);
            }

            // Ovdje je Mjesto na osoba null
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            // ovdje na osoba dodjeljujem Mjesto na novu instancu klase mjesto s vrijednočću naziva Osijek
            osoba.Mjesto = new() { Naziv = "Osijek" };
           
            // Ovdje Mjesto nije null i naziv je postavljen
            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");



            osoba.Ime = "Pero";

            osoba.Mjesto.Zupanija = new Zupanija() { Naziv = "OBŽ", Zupan = new() { Ime = "Nataša" } };

            // Koji je smisao OOP-a 

            Console.WriteLine(osoba.Mjesto.Zupanija.Zupan.Ime);


            // ispisati Pero s objekta osoba
            Console.WriteLine(osoba.Ime);

            // ispisati OBŽ s objekta osoba
            Console.WriteLine(osoba.Mjesto?.Zupanija.Naziv);

            //ispšisati Osijek s objekta osoba
            Console.WriteLine(osoba.Mjesto?.Naziv);


            // Zadatak: 
            // Kreirati klasu Automobil s 5 svojstava 

          public static void AutomobilZadatak()
            {
            Automobil automobil = new Automobil();
            automobil.Sifra = 1;
            automobil.Marka = "Mercedes";
            automobil.Automatik = false;
            automobil.DatumProizvodnje = new DateTime(1991, 11, 1);
            automobil.Cijena = 14525.20M;

            Console.WriteLine(automobil.DatumProizvodnje);

            }

        }

    }

