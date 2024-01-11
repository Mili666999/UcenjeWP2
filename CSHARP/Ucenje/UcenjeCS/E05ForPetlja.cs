using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05ForPetlja
    {
        public static void Izvedi() 
        {

            //Ispisati 10x Edunova:
            //Najgore riješenje
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");
            //Console.WriteLine("Edunova");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Edunova");
            }


            //Varijabla izvan petlje
            int t;
            for (t = 0; t < 10; t++)
            {
                Console.WriteLine("Edunova T");
            }


            //Varijabla u petlji mijenja vrijednost
            for(int i = 0; i < 10; ++i) 
            {
                Console.WriteLine(i+1);
            }


            //Ne mora biti uvećanje, može i umanjenje
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }


            //Korak uvećanja/umanjenja može biti veći od 1
            for (int i = 0; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }


            //Ispisati sve parne  brojeve između 3 i 23
            Console.WriteLine("******************************");
            int ukpb = 56;
            int ukdb = 56;
            
            int Manji = ukpb < ukdb ? ukpb : ukdb;
            int Veci = ukpb > ukdb ? ukpb : ukdb;

            if(Manji == Veci && Manji % 2 != 0) 
            {
                Console.WriteLine("Unjeli ste iste brojeve, nema parnih");
            }

            for (int i = Manji; i <= Veci; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("******************************");
            for (int i = 0; i < 10; i++)
            { 
                for (int j = 0; j < 10; j++) 
                {
                    Console.Write((i+1) * (j+1) + "\t");
                }
                Console.WriteLine();
            }


            //Petlja se može preskočiti
            Console.WriteLine("******************************");
            for (int i = 0; i < 10; i++)
            { 
                if(i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            //Petlja se može nasilno prekinuti
            Console.WriteLine("******************************");
            for (int i = 0; i < 10; i++)
            { 
                if(i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            //Beskonačna petlja
            for (; ; )
            {
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Console.Write(new Random().Next(10, 100) + " ");
                Thread.Sleep(50);
                break;
            }


            //Za unešeni broj između 1 i 10 ispiši kvadrat tog broja
            //Console.WriteLine("******************************");
            //int Broj;

            //for(; ; ) 
            //{
            //    Console.Write("Unesi broj između 1 i 10: ");
            //    Broj = int.Parse(Console.ReadLine());
            //    if(Broj >= 1 && Broj <= 10) 
            //    {
            //        break;                
            //    }
            //    Console.WriteLine("Krivi unos!");
            //}

            //Console.WriteLine(Broj * Broj);






        }
    }
}
