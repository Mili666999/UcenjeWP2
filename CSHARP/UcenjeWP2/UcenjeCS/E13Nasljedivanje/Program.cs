using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13Nasljedivanje
{
    internal class Program
    {
        public static void Izvedi()
        {
            var p = new Polaznik()
            { 
                Sifra = 1,
                Ime = "Pero",
                Prezime = "Perić",
                BrojUgovora = "02/2024"
            };

            //Ispisati 1
            Console.WriteLine(p.Sifra);


            var pr1 = new Predavac();
            pr1.Ime = "Mario";

            var pr2 = new Predavac();
            pr2.Ime = "Mario";

            Console.WriteLine((pr1==pr2) + ", " + pr1.GetHashCode() + " == " + pr2.GetHashCode());


            //var e = new Entitet(); // Ne može se instancirati abstraktna klasa
            //e.Sifra = 2;



        }
    }
}
