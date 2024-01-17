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
            Zbroj(KreiranjeNiza());
        }

        //Unos brojeva i kreiranje niza
        public static int[] KreiranjeNiza()
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

        //Zbrajanje brojeva niza
        public static void Zbroj(int[] Niz)
        {
            int Zbroj = 0;

            foreach (int n in Niz) 
            {
                Zbroj = Zbroj + n;
            }

            Console.WriteLine("Zbroj je: " + Zbroj);
        }
    }
}
