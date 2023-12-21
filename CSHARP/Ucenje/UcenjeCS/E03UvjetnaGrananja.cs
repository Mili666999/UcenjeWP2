using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnaGrananja
    {
        public static void Izvedi()
        { 
            int i = 7;

            // Binarno grananje
            bool Uvjet = i == 7;
            if (Uvjet) 
            {
                Console.WriteLine($"Broj je {i}, ušao sam u true dio if naredbe");
            }

            // U pravilu se ovako piše
            if (i == 7) 
            {
                Console.WriteLine("Isti uvjet kao i predhodno");
            }

            // Drugi (neobavezni) dio if naredbe - else
            if (i < 5)
            {
                Console.WriteLine("i je manji od 5");
            }
            else 
            {
                Console.WriteLine("i nije manji od 5");
            }

            // Puni izgled if naredbe
            if (i == 2)
            {
                Console.WriteLine("i je 2");
            }
            else if (i == 3)
            {
                Console.WriteLine(" i je 3");
            }
            else 
            {
                Console.WriteLine("I nije ni 2 ni 3");
            }

            int j = 2;
            if (i == 7) 
            {
                if(j == 2) 
                {
                    Console.WriteLine("Oba uvjeta su zadovoljena - ugnježđeno");
                }
            }

            // Logičko & i uvjetovani &&

            // & provjeravaju se oba uvjeta bez obzira jel prvi prošao
            i = 5;
            if(i == 7 & j == 2) 
            {
                Console.WriteLine("Oba uvjeta su zadovoljena &");
            }
            // && ukoliko prvi uvjet padne ne provjerava se drugi
            if (i == 7 && j == 2) 
            {
                Console.WriteLine("Oba uvjeta su zadovoljena &&");
            }

            // Logičko | i uvjetovano ||

            // | provjeravaju se oba uvjeta bez obzira jel prvi prošao
            if (i == 5 | j == 1) 
            {
                Console.WriteLine("Dovoljno je da jedan uvjet bude zadovoljen");
            }
            // || ukoliko prvi uvjet padne ne provjerava se drugi
            if (i == 5 || j == 2) 
            {
                Console.WriteLine("Prvi uvjet uvjet zadovoljen, drugi se ne provjerava");
            }

            // Logično NE (!)
            if ((i == 5 || j == 1) && !(i > 5 || j < 8))
            {
                Console.WriteLine("Komplicirani izraz");
            }

            // Skraćeni način pisanja - inline if
            
            // Program upsuje cijeli broj
            // Ako je broj veći od 10 ispisuje Osijek inače ispisuje Zagreb
            Console.Write("Unesi cijeli broj: ");
            int Broj = int.Parse(Console.ReadLine());
            if (Broj > 10)
            {
                Console.WriteLine("Osijek");
            }
            else
            {
                Console.WriteLine("Zagreb");
            }
            // Skraćeno - inline if
            Console.WriteLine(Broj>10 ? "Osijek" : "Zagreb");


            // Višestruko grananje
            Console.Write("Unesi ocjenu: ");
            int Ocjena = int.Parse(Console.ReadLine());

            switch(Ocjena) 
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    case 3:
                    Console.WriteLine("Dovoljno ili dobro");
                    break;
                case 4:
                    case 5:
                    Console.WriteLine("To je ocjena");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;
            }
            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine();
            switch(ime) 
            {
                case "Marko":
                    Console.WriteLine("OK");
                    break;
                case "Pero":
                    Console.WriteLine("Super");
                    break;
            }
        }
    }
}
