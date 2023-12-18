using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {
            //Console.WriteLine(7);
            //Console.WriteLine(true);
            //Console.Write("Prvi");
            //Console.Write("Drugi");
            //Console.WriteLine(3.14);


            //Console.Write("Unesi ime: ");
            //string Ime = Console.ReadLine();
            //Console.WriteLine("Unjeli ste: " + Ime);


            //Console.Write("Unesi visinu u centimetrima: ");
            //int Visina = int.Parse(Console.ReadLine());

            //float VisinaUMetrima = (float)Visina / 100;

            //Console.WriteLine("Visoki ste: " + VisinaUMetrima + " metara");


            //Console.Write("Unesi decimalni broj: ");
            //float x = float.Parse(Console.ReadLine());
            //Console.WriteLine(x);


            Console.Write("Unesi dužinu: ");
            float Duzina = float.Parse(Console.ReadLine());
            Console.Write("Unesi širinu: ");
            float Sirina = float.Parse(Console.ReadLine());

            var Povrsina = Duzina * Sirina;

            Console.WriteLine("Površina je: " + Povrsina);
        }

    }
}
