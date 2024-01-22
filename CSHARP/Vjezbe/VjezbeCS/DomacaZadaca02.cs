using System;
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
            int Odabir = 0;

            for (; ; )
            {
                Console.WriteLine("Za ZBROJ birajte 1");
                Console.WriteLine("Za NAJMANJI birajte 2");
                Console.WriteLine("Za NAJVEĆI birajte 3");
                Console.WriteLine("Za PROSJEK birajte 4");
                Console.WriteLine("Za IZLAZ birajte 0");
                Console.WriteLine("");
                try
                {
                    Odabir = int.Parse(Console.ReadLine());
                    switch (Odabir)
                    {
                        case 1:
                            Zbroj(KreiranjeNiza());
                            break;
                        case 2:
                            Najmanji(KreiranjeNiza());
                            break;
                        case 3:
                            Najveci(KreiranjeNiza());
                            break;
                        case 4:
                            Prosjek(KreiranjeNiza());
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nisi unio broj, probaj opet...");
                    Console.WriteLine("");
                    Izvedi();
                }

                if (Odabir == 0)
                {
                    break;
                }
            }
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
                
                try
                {
                    Broj = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nisi unio broj, probaj opet...");
                }
               
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

            Console.WriteLine("");
            Console.WriteLine("Zbroj je: " + Zbroj);
            Console.WriteLine("");
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

            Console.WriteLine("");
            Console.WriteLine("Najmanji je: " + Najmanji);
            Console.WriteLine("");
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

            Console.WriteLine("");
            Console.WriteLine("Najveći je: " + Najveci);
            Console.WriteLine("");
        }


        // 4. Prosjek svih unesenih brojeva
        internal static void Prosjek(int[] Niz)
        {
            int i = 0;
            int Zbroj = 0;

            foreach (int n in Niz)
            { 
                Zbroj += n;
                i++;
            }
            var Prosjek = Zbroj / i;
            
            Console.WriteLine("");
            Console.WriteLine("Prosjek je: " + Prosjek);
            Console.WriteLine("");
        }



    }
}
