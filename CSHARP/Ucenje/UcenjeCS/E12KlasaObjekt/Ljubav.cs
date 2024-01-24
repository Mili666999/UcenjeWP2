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

            string SpojImena = PrvoIme.Trim().ToLower() + DrugoIme.Trim().ToLower();
            char[] Znakovi = SpojImena.ToCharArray();
            
            int[] Brojevi = new int[Znakovi.Length];
            int Zbroj;
            int index = 0;
            
            foreach (char c in Znakovi) 
            {
                Zbroj = 0;
                foreach (char cc in Znakovi)
                {
                    if (c == cc)
                    { 
                        Zbroj++;
                    }
                }
                Brojevi[index++] = Zbroj;
            }

            return Brojevi;

        }

        private int Izracunaj(int[] BrojevniNiz)
        {

            int Rezultat = 0;
            int[] NoviNiz = new int[0];
            
            //Kreiram NoviNiz upola manji od BrojevnogNiza ako je ovaj paran
            //Ili upola + 1 ako je BrojevniNiz neparan
            if (BrojevniNiz.Length % 2 == 0)
            {
                NoviNiz = new int[BrojevniNiz.Length / 2];
            }
            else
            {
                NoviNiz = new int[(BrojevniNiz.Length / 2) + 1];
            }
            
            //Zbrajam elemente BrojevnogNiza do sredine
            //(ako je niz neparan, središnji element ne diram)
            for(int i = 0,j = BrojevniNiz.Length-1; i < BrojevniNiz.Length/2 && j >= BrojevniNiz.Length/2; i++, j--) 
            {
                NoviNiz[i] = BrojevniNiz[i] + BrojevniNiz[j];
            }

            //Ako je BrojevniNiz neparan, središnji element stavljam na kraj NovogNiza
            if (BrojevniNiz.Length % 2 != 0)
            {
                NoviNiz[NoviNiz.Length - 1] = BrojevniNiz[(BrojevniNiz.Length / 2) + 1];
            }

            //Prebacujem NoviNiz u string da bi se riješio dvoznamenkastih brojeva
            //i provjeravam Rezultat
            string Brojevi = string.Join("", NoviNiz);
            Rezultat = Int32.Parse(Brojevi);
            if (Rezultat > 100)
            {
                NoviNiz = Brojevi.Split(',').Select(int.Parse).ToArray();
                Izracunaj(NoviNiz);
            }
            
            return Rezultat;

        }

        

    }
}
