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

            string NizSLova = ljubav.PrvoIme + ljubav.DrugoIme;
            Console.WriteLine(NizSLova);


            return new int[2];
        }

        private int Izracunaj(int[] Brojevi)
        {

            Console.WriteLine(SlovaUNiz);
            return 67;
        }

        

    }
}
