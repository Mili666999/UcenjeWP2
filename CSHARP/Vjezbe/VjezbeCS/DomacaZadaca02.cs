﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeCS
{

    // Program učitava brojeve sve dok se ne unese -1
    // Program ispisuje:
    // 1. Zbroj unesenih brojeva
    // 2. Najmanji broj
    // 3. Najveći broj
    // 4. Prosjek svih unesenih brojeva

    // KORISTITI METODE I OBRADU IZNIMKI

    internal class DomacaZadaca02
    {

        internal static void Izvedi()
        {
            //Zbroj(KreiranjeNiza());
            //Najmanji(KreiranjeNiza());
            //Najveci(KreiranjeNiza());
            Prosjek(KreiranjeNiza());
        }

        
        //Unos brojeva i kreiranje niza
        internal static int[] KreiranjeNiza()
        {
            int i = 0;
            int j = 0;
            int Broj = 0;
            int[] PocetniNiz = new int[100];
            

            for (; ; )
            {
                Console.Write("Unesi broj: ");
                Broj = int.Parse(Console.ReadLine());
                
                if (Broj == -1) 
                {
                    break;
                }
                PocetniNiz[i] = Broj;
                i++;
            }

            int[] Niz = new int[i];

            foreach (int n in PocetniNiz)
            {
                if (j >= i)
                {
                    break;
                }
                Niz[j] = n;
                j++;
            }

            return Niz;
        }

        
        // 1. Zbroj unesenih brojeva
        internal static void Zbroj(int[] Niz)
        {
            int Zbroj = 0;

            foreach (int n in Niz) 
            {
                Zbroj = Zbroj + n;
            }

            Console.WriteLine("Zbroj je: " + Zbroj);
        }


        // 2. Najmanji broj
        internal static void Najmanji(int[] Niz)
        {
            int Najmanji = int.MaxValue;

            foreach (int n in Niz)
            {
                if (n < Najmanji)
                { 
                    Najmanji = n;
                }
            }

            Console.WriteLine("Najmanji je: " + Najmanji);
        }


        // 3. Najveći broj
        internal static void Najveci(int[] Niz)
        {
            int Najveci = int.MinValue;

            foreach (int n in Niz)
            {
                if (n > Najveci)
                {
                    Najveci = n;
                }
            }

            Console.WriteLine("Najveći je: " + Najveci);
        }


        // 4. Prosjek svih unesenih brojeva
        internal static void Prosjek(int[] Niz)
        {
            int i = 0;
            int Zbroj = 0;
            int Prosjek = 0;

            foreach (int n in Niz)
            { 
                Zbroj += n;
                i++;
            }

            Console.WriteLine("Prosjek je: " + Zbroj/i);
        }



    }
}
