using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Osoba:Entitet
    {
        private int NeVidim;
        protected int Vidim;
        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public string Email { get; set; }
    }
}
