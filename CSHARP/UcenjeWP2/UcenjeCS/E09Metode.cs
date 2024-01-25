using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09Metode
    {
        public static void Izvedi()
        {
            Tip1();
            
            Tip2(1,8);
            
            //var uzima tip podatka s desne strane
            var Ime = Tip3();
            Console.WriteLine(Ime);
            //bolje:
            Console.WriteLine(Tip3());

            Console.WriteLine(PrimBroj(8) ? "PRIM" : "NIJE");

            //Ispiši sve prim brojeve između dva broja
            SviprimBrojevi(33,66);
        }

       



        //1. vrsta: tipa void, ne prima vrijednost, ne prima parametre (prima praznu listu parametara)

        static void Tip1()
        {
            Console.WriteLine("Hello iz tip 1");
        }

        //2. vrsta: tipa void, prima parametre

        static void Tip2(int Od, int Do)
        {
            //ispiši sve parne brojeve između 2 parametra           
            for (int i = Od;  i <= Do; i++) 
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        //3. vrsta: određenog tipa koji vraća pozivatelju i ne prima parametre

        static string Tip3() 
        {
            return System.Net.Dns.GetHostName();
        }

        //4. vrsta: određenog tipa koji vraća pozivatelju i prima parametre

        static bool PrimBroj(int Broj)
        {
            for (int i = 2; i < Broj; i++)
            {
                if (Broj % i == 0)
                {
                    return false; // shortcuircuting
                }
            }

            return true;
        }



        private static void SviprimBrojevi(int Od, int Do)
        {
            for (int i = Od; i <= Do; i++)
            {
                if (PrimBroj(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
