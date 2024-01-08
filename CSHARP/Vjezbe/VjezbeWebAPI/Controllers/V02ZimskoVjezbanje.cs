using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text;

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
                {
                    Niz[Index++] = i; 
                }
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
                { 
                    Niz[Index++] = i; 
                }
            }
            
            return Niz;
        }


        [HttpGet]
        [Route("Zadatak7")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva
        public int Zad7(int x, int y) 
        {
            int Zbroj = 0;
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

            for (int i = Manji; i <= Veci; i++)
            {
                Zbroj += i;
            }
            
            return Zbroj;
        }


        [HttpGet]
        [Route("Zadatak8")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva koji su cjelobrojno djeljivi s 3
        public int Zad8(int x, int y) 
        {
            int Zbroj = 0;
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

            for (int i = Manji; i <= Veci; i++)
            {
                if (i % 3 == 0)
                {
                    Zbroj += i;
                }
            }

            return Zbroj;
        }


        [HttpGet]
        [Route("Zadatak9")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća zbroj svih brojeva između primljenih brojeva koji su cjelobrojno djeljivi s 3 i 5
        public int Zad9(int x, int y) 
        {
            int Zbroj = 0;
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

            for (int i = Manji; i <= Veci; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Zbroj += i;
                }
            }

            return Zbroj;
        }


        [HttpGet]
        [Route("Zadatak10 - NEDOVRŠEN")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća dvodimenzionalni niz (matricu) koja sadrži tablicu množenja za dva primljena broja

        public String Zad10(int x, int y) 
        {
            StringBuilder SB = new StringBuilder();

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    int Umnozak = i * j;
                    SB.Append(Umnozak);
                }
            }

            return SB.ToString;
        }


        [HttpGet]
        [Route("Zadatak11")]

        //Ruta prima jedan parametar koji je cijeli broj i vraća niz cijelih brojeva koji su složeni od primljenog broja do broja 1

        public int[] Zad11(int x)
        {
            int Brojac = 0;
            int[] Niz = new int[x];

            for (int i = x; i >= 1; i--)
            {
                Niz[Brojac++] = i;
            }

            return Niz;
        }


        [HttpGet]
        [Route("Zadatak12")]

        //Ruta prima cijeli broj i vraća logičku istinu ako je primljeni broj prosti (prim - prime) broj, odnosno logičku laž ako nije

        public bool Zad12(int x) 
        {
            int Brojac = 0;

            if (x < 0)
            { 
                x = -x;
            }

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                { 
                    Brojac++;
                }
            }

            return (Brojac==2 ? true : false);
        }
    }
}
