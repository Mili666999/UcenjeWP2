using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07DoWhilePetlja
    {
        public static void Izvedi() 
        {
            //U FOR i WHILE petlje se ne mora nužno ući, ako uvjet na početku nije zadovoljen
            //DO WHILE osigurava minimalno jedno izvođenje, jer je uvjet na kraju petlje
            do
            {
                Console.WriteLine("Edunova");
            } while (false);

            //Continue, break i ugnježđivanje isto kao kod for i while



            //Prekidanje vanjske petlje iz unutrašnje:
            for(; ; ) 
            {
                while (true) 
                {
                    do
                    {
                        goto nakonfor;
                    } while (true);
                }
            }
            nakonfor:   //Ovo je labela
            Console.WriteLine("Odradio");



        }
    }
}
