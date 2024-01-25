using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Polaznik:Osoba //Klasa Polaznik nasljeđuje sva javna i zaštićena svojstva iz klase Osoba
    {
        public string BrojUgovora { get; set; }


        private void ProvjeraVidljivosti()
        {
            Vidim = 2; //Ovo je u mojoj klasi
            base.Sifra = 2; 
            base.Vidim = 7; // Ovo je u nadklasi
            this.Vidim = 8; // Ovo je u mojoj klasi
            //NeVidim // Ovo se ne vidi
        }

    }
}
