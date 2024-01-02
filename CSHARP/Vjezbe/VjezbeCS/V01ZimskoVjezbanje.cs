using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Ispis1Do100()
        { 
            for (int i = 0; i < 100;  i++) 
            {
                Console.WriteLine(i);
            }
        }

        public static void Ispis100Do1()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Ispis1Do100DjeljiviSa7() 
        {
            for(int i = 1; i < 100; i++) 
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void VeciOd100()
        {
            int i = 0;
            int j = 0;

            Console.WriteLine("Pokušaj unjeti broj veći od 100");

            for ( ; ; ) 
            {
                i = int.Parse(Console.ReadLine());
                if (i > 100) 
                {
                    break;
                }
                j++;
            }
            Console.WriteLine("Unjeli ste broj iz " + j + " pokušaja!");
        }
    }
}
