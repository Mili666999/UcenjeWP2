using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10ObradaIznimki
    {
        public static void Izvedi()
        {
            int PB = UcitajBroj("Unesi prvi broj: ");
            int DB = UcitajBroj("Daj mi i drugi: ");

            IspisiBrojeve(PB, DB);
       
        }


        private static void IspisiBrojeve(int pB, int dB)
        {
            var Manji = pB <= dB ? pB : dB;
            var Veci = pB >= dB ? pB : dB;

            for(int i = Manji; i <= Veci; i++)
            {
                Console.WriteLine(i);
            }
        }


        private static int UcitajBroj(string v)
        {
            for (; ; )
            {
                Console.Write(v);

                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Nisi unio broj");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Nešto gadno ne valja");
                }
                catch (Exception) //Ovdje hvata bilo koju iznimku koja nije prije obrađena
                {
                    Console.WriteLine("Ooops");
                }
                finally
                {
                    Console.WriteLine("Mjesto na koje se dolazi pukao ti ili ne");
                }

            }

            

            //return 0;
        }
    }
}
