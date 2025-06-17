

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
                Pomocno.ucitajCijeliBroj("Unesi dan rođenja"
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

        }

    }
}
