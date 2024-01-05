using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeCS
{
    internal class V01ZimskoVjezbanje
    {
        //Napisati program koji ispisuje sve brojeve od 1 do 100
        public static void Ispis1Do100()
        { 
            for (int i = 1; i <= 100;  i++) 
            {
                Console.WriteLine(i);
            }
        }


        //Napisati program koji ispisuje sve brojeve od 100 do 1
        public static void Ispis100Do1()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Napisati program koji ispisuje sve brojeve od 1 do 100 koji su cjelobrojno djeljivi s 7
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


        //Napisati program koji unosi brojeve sve dok ne unese broj veći od 100, a zatim ispisuje koliko je bilo pokušaja unosa
        public static void VeciOd100()
        {
            int i = 0;
            int j = 1;

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


        //Tablica množenja
        public static void TablicaMnozenja()
        {
            Console.Write("Unesi prvi broj: ");
            int x = int.Parse(Console.ReadLine()) ;
            Console.Write("Unesi drugi broj: ");
            int y= int.Parse(Console.ReadLine()) ;

            int[,] Tablica = new int[x, y];

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write((Tablica[i-1, j-1] = i * j) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
