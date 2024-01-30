using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaAPP
{
    internal class Pomocno
    {
        public static int UcitajInt(string poruka)
        {
            for (; ; )
            {
                Console.Write(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Neispravan unos");
                }
            }
        }


        public static string UcitajString(string poruka)
        {
            string s;
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine();
                if (s.Trim().Length == 0)
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }
        }


        public static int UcitajBrojRaspon(string poruka, string greska,
           int poc, int kraj)
        {
            int b;
            while (true)
            {
                Console.Write(poruka);
                try
                {
                    b = int.Parse(Console.ReadLine());
                    if (b >= poc && b <= kraj)
                    {
                        return b;
                    }
                    Console.WriteLine(greska);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(greska);
                }
            }
        }
    }
}
