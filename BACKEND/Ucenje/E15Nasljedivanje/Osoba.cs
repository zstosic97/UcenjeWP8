using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    // Apstraktna klasa je ona klasa koja nema implementaciju (instancu)
    // služi da bi se nasljedila i proširila
    public abstract class Osoba : Object // SVE Klase NASLJEĐUJU KLASU oBJECT HTJELE ONE TO IL NE 
    {
        public int Sifra { get; set; }
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string? Email { get; set; }

        public override string ToString()
        {
            // return Ime + " " + Prezime;
            return new StringBuilder().Append(Ime).Append(' ').Append(Prezime).ToString();

        }
    }
}
