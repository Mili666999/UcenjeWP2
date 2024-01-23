using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Ljubav
    {
        public string? PrvoIme { get; set; }
        public string? DrugoIme { get; set; }


        //Ovo je konstruktor - %. vrsta metode
        public Ljubav() 
        {
            //Ovdje se dolazi  kada se izvodi ključna riječ "new"
        }


        public Ljubav(string? prvoIme, string? drugoIme)
        {
            PrvoIme = prvoIme;
            DrugoIme = drugoIme;
        }

        public string Rezultat()
        {
            return Izracunaj(SlovaUNiz(PrvoIme + DrugoIme)) + " %";
        }

        private int[] SlovaUNiz(string Imena)
        {
            Ljubav ljubav = new Ljubav();

            string SpojImena = PrvoIme.Trim() + DrugoIme.Trim();
            char[] Znakovi = SpojImena.ToCharArray();
            
            int[] Brojevi = new int[Znakovi.Length];
            int Ukupno;
            int index = 0;
            
            foreach (char c in Znakovi) 
            {
                Ukupno = 0;
                foreach (char cc in Znakovi)
                {
                    if (c == cc)
                    { 
                        Ukupno++;
                    }
                }
                Brojevi[index++] = Ukupno;
            }

            return Brojevi;
        }

        private int Izracunaj(int[] Brojevi)
        {
            int Rezultat = 0;
            int Index = 0;
            int[] NoviNiz = new int[Brojevi.Length/2];

            for(int i = 0; i < Brojevi.Length; i++) 
            {
                for (int j = 0; j > Brojevi.Length; j--)
                {
                    NoviNiz[Index] = Brojevi[i] + Brojevi[j];
                    Index++;
                }
            }



            return Rezultat;
        }

        

    }
}
