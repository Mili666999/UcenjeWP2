using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E08ForEachPetlja
    {
        public static void Izvedi() 
        {
            int[] Niz = { 1, 2, 3, };

            for (int i = 0; i < Niz.Length; i++) 
            {
                Console.WriteLine(Niz[i]);
            }

            //Gornji kod je ekvivalent donjem

            foreach (int Element in Niz)
            {
                Console.WriteLine(Element);
            }

            //Sve ostale značajke petlji funkcioniraju jednako

            string Ime = "Edunova šđčćžŠĐČĆŽ";
            Console.WriteLine(Ime);

            foreach (char c in Ime)
            {
                Console.WriteLine(c + ": " +(int)c);
            }

            Console.WriteLine("******************************");
            //Korisnik unosi tekst, a program ispisuje koje slovo je unio koliko puta
            //Osijek je super grad

            Console.WriteLine("Unesi tekst: ");
            string Unos = Console.ReadLine();

            int Index = 0;
            int Ukupno;
            int[] Slova = new int[Unos.Length];

            foreach (char c in Unos)
            {
                Ukupno = 0;
                foreach (char cc in Unos)
                {
                    if (c == cc)
                    {
                        Ukupno++;
                    }
                }
                Slova[Index++] = Ukupno;
            }

            Console.WriteLine(string.Join(",", Slova));

            char[] JedinstvenaSlova = new char[Unos.Length]; // ne treba mi toliko prostora, njaveći nedostatak nizova je taj što se na početku mora reći koliko ima elemenata
            bool postoji;
            Index = 0;
            foreach (char c in Unos)
            {
                postoji = false;
                foreach (char cc in JedinstvenaSlova)
                {
                    if (c == cc)
                    {
                        postoji = true;
                        break;
                    }
                }
                if (!postoji)
                {
                    JedinstvenaSlova[Index++] = c;
                }
            }

            Console.WriteLine(string.Join(",", JedinstvenaSlova));

            foreach (char c in JedinstvenaSlova)
            {
                Console.Write(c + " ");
                Index = 0;

                foreach (char cc in Unos)
                {
                    if (c == cc)
                    {
                        Console.WriteLine(Slova[Index]);
                        break;
                    }
                    Index++;
                }
            }


        }
    }
}
