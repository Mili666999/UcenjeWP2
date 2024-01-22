using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    internal class Program
    {
        public static void Izvedi()
        {

            Osoba o = new Osoba();
            Grad g = new()
            {
                //Naziv = "Osijek",
                BrojStanovnika = 100000
            };

            o.Grad = g;

            //Ispisati Osijek na instanci klase Osoba
            Console.WriteLine(o.Grad.Naziv);

        }

        private static string Unos(string Poruka) 
        {
            string Unos;
            while (true)
            {

                Console.Write(Poruka);
                Unos = Console.ReadLine();

                if(Unos.Trim().Length == 0) 
                {
                    Console.WriteLine("Unos obavezan");
                    continue;
                }
                return Unos;
            
            }
        }


        private static void E04LJubavniZov()
        {
            Ljubav ljubav = new(); // S "new" se poziva konstruktor

            //Console.Write("Unesi prvo ime: ");
            //ljubav.PrvoIme = Console.ReadLine();

            ljubav.PrvoIme = Unos("Unesi prvo ime: ");
            ljubav.DrugoIme = Unos("Unesi drugo ime: ");

            Console.WriteLine(ljubav.Rezultat());

            Console.WriteLine(new Ljubav(Unos("PI"), Unos("DI")).Rezultat());
        }


        private static void E03Najcesce()
        {
            //Najčešći način deklaracije
            Osoba osoba = new();

            var Pjevac = new Osoba();

            Pjevac.Ime = "Mirko";

            Console.WriteLine(Pjevac.Ime?.Substring(0, 1));
        }


        private static void E02DrugaSintaksa() 
        {
            Osoba o = new Osoba
            {
                Ime = Console.ReadLine(),
                Prezime = Console.ReadLine()
            };

            Console.WriteLine(o.ImePrezime());
        }


        private static void E01OsnovnaSintaksa()
        {
            //Objekt je instanca klase
            Osoba osoba = new Osoba();

            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);
        }



    }
}
