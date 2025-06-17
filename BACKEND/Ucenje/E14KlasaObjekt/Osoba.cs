using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    // Klasa je opisnik objekta  -----> naučiti napamet
    internal class Osoba
    {
        // klasa se sastoji od svojstava
        // princip učahurivanja (OOP princip)   
        public int Sifra { get; set; }
        public string? Ime { get; set; }  // upitnik znači da svojstvo može biti null 
        public string Prezime { get; set; } = ""; // ="" će postaviti prazno, neće biti null  
        public DateTime? DatumRodenja
        {
            get; set;



        }
    }
}