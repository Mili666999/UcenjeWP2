using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06WhilePetlja
    {
        public static void Izvedi() 
        {
            bool Uvjet = true;
            int i = 0;

            while(Uvjet) 
            {
                i += 1;
                Console.WriteLine(i);

                Uvjet = i < 10;
            }

            Console.WriteLine("**************************************");

            i = 0;
            while(i < 10) 
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("**************************************");

            //Continue
            i = 0;
            while(i++ < 10) 
            {
                if (i == 2) //prilikom ispisa preskače se 2
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************************");

            //Break
            while(true) 
            {
                Console.WriteLine("Edunova");
                break;
            }

            Console.WriteLine("**************************************");

            //Ugnježđivanje
            i = 0;
            while(++i < 10) 
            {
                while (true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("**************************************");

            //Korisnik unosi broj, program ispisuje sve brojeve do 100
            Console.Write("Unesi broj: ");
            int Broj = int.Parse(Console.ReadLine());

            if (Broj > 100)
            {
                while (Broj > 100)
                {
                    Console.WriteLine(Broj--);
                }
            }

            while (Broj <= 100)
            {
                Console.WriteLine(Broj++);
            }



        }
    }
}
