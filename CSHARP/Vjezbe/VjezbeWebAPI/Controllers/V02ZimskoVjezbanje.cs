using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace VjezbeWebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {
        [HttpGet]
        [Route("Zadatak1")]

        //Ruta ne prima niti jedan parametar i vraća zbroj prvih 100 brojeva
        public int Zad1()
        {
            int Zbroj = 0;
            for (int i = 1; i <= 100; i++)
            {
                Zbroj += i;
            }
            return Zbroj;
        }

        
        [HttpGet]
        [Route("Zadatak2")]

        //Ruta ne prima niti jedan parametar i vraća niz sa svim parnim brojevima od 1 do 57
        public int[] Zad2() 
        {
            int[] Niz = new int[28];

            int Index = 0;
            
            for (int i = 1; i <= 57; i++)
            {
                if (i % 2 == 0)
                {
                    Niz[Index++] = i;
                }
            }

            return Niz;
        }


        [HttpGet]
        [Route("Zadatak3")]

        //Ruta ne prima niti jedan parametar i vraća zbroj svih parnih brojeva od 2 do 18
        public int Zad3()
        {
            int Zbroj = 0;
            for (int i = 2; i <= 18; i++)
            {
                if ((i % 2) == 0)
                {
                    Zbroj += i;
                }
                
            }
            return Zbroj;
        }


        [HttpGet]
        [Route("Zadatak4")]

        //Ruta prima jedan parametar koji je cijeli broj i vraća zbroj svih brojeva od 1 do primljenog broja
        public int Zad4(int x)
        {
            int Zbroj = 0;
            for (int i = 1; i <= x; i++)
            {
                Zbroj+=i;
            }
            return Zbroj;
        }


        [HttpGet]
        [Route("Zadatak5")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća niz sa svim parnim brojevima između primljenih brojeva
        public int[] Zad5(int x, int y)
        {
            int Index = 0;
            int Manji = 0;
            int Veci = 0;

            if (x < y)
            {
                Manji = x;
                Veci = y;
            }
            else
            { 
                Manji=y;
                Veci = x;
            }

            int[] Niz = new int[Veci / 2];

            for (int i = Manji; i <= Veci; i++)
            {
                if(i % 2 == 0)
                { Niz[Index++] = i; }
            }
            return Niz;
        }


        [HttpGet]
        [Route("Zadatak6")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća niz s svim neparnim brojevima između primljenih brojeva
        public int[] Zad6(int x, int y)
        {
            int Index = 0;
            int Manji = 0;
            int Veci = 0;

            if (x < y)
            {
                Manji = x;
                Veci = y;
            }
            else
            {
                Manji = y;
                Veci = x;
            }

            int[] Niz = new int[Veci / 2];

            for (int i = Manji; i <= Veci; i++)
            {
                if (i % 2 != 0)
                { Niz[Index++] = i; }
            }
            return Niz;
        }
    }
}
