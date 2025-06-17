using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    // Klasa je opisnik objekta  -----> naučiti napamet
    public class Osoba
    {
        // klasa se sastoji od svojstava
        // princip učahurivanja (OOP princip)   
        public int Sifra { get; set; }
        public string? Ime { get; set; }  // upitnik znači da svojstvo može biti null 
        public string Prezime { get; set; } = ""; // ="" će postaviti prazno, neće biti null  
        public DateTime? DatumRodenja {get; set;}


        // prvi tekst Mjesto je klasa, a drugi tekst Mjesto je svojstvo 
        // Ovo je veza 1:n u bazi 
        public Mjesto? Mjesto { get; set; }

        public Mjesto[]? Mjesta { get; set; }

        // klasa se sastoji od metoda
        // ova metoda nije static! 

        public void IspisiImeIPrezime()
        {

            Console.WriteLine(this.Ime + " " + Prezime);
        }

        // statične metode se pozivaju na klasi a ne statične na objektu 


        public static void Primjer()
        {

            Console.WriteLine("Primjer statične metode");
        }

    }
}