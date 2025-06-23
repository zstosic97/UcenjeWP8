using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{

    // sve iz osobe mi odgovara, a od osobe ne mogu napraviti klasu jer je Osoba apstrakta
    public class PotencijalniPolaznik : Osoba
    {
        public string? Napomena { get; set; }
    }
}
