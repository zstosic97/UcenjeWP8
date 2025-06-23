﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.edunova
{
    internal class Grupa
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public Smjer Smjer { get; set; } = new Smjer();
        public string? Predavac {  get; set; }
        public Polaznik[]? Polaznici { get; set; }  


    }
}
