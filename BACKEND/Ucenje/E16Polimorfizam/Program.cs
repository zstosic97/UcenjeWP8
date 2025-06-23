using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Program
    {

        public Program()
        {

            Console.WriteLine("Polimorfizam");

            Osoba[] osobe = new Osoba[5];

            osobe[0] = new Polaznik() { Ime = "Pero", Telefon = "258" };
            osobe[1] = new Predavac() { Ime = "Karla", IBAN = "HR344324" };
            osobe[2] = new Predavac() { Ime = "Lota", IBAN = "HR1213214" };
            osobe[3] = new Polaznik() { Ime = "Ivana", Telefon = "2124123" };
            osobe[4] = new Predavac() { Ime = "Josip", IBAN = "HR034381" };

            Ispisi(osobe);

            var p = new Polaznik();
            p.Log("Problem kod prijave");

            var r = new Ravnatelj();
            r.Log("Ravnatelj je izuzet");

            r.Log("Ravnatelj je izuzet");

        }

        public static void Ispisi(Osoba[] osobe)
        {
            foreach(Osoba o in osobe)
            {
                // ovo je polimorfizam
                Console.WriteLine(o.Pozdravi());

            }
        }







    }
}
