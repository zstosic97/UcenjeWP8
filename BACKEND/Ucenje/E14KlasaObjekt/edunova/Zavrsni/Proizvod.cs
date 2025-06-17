using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.edunova.Zavrsni
{
   public class Proizvod
    {
        public int Sifra { get; set; }
        public string NazivProizvoda { get; set; } = "";
        public decimal Kolicina { get; set; }
        public Prodavatelj Prodavatelj { get; set; }
        public Kategorijaproizvoda Kategorijaproizvoda { get; set; }
    }
}
