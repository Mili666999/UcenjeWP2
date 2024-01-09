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
        [Route("Zadatak10")]

        //Ruta prima dva parametra koji su cijeli brojevi i vraća dvodimenzionalni niz (matricu) koja sadrži tablicu množenja za dva primljena broja

        public String Zad10(int x, int y) 
        {
            int[,] Tablica = new int[x,y];
            StringBuilder SB = new StringBuilder();

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Tablica[i-1,j-1] = i*j;
                    SB.Append(Tablica[i-1,j-1] + "\t");
                }
                SB.AppendLine();
            }

            return SB.ToString();
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

            if (x == 1 || x == -1)
            { 
                return true;
            }

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

            return (Brojac == 2 ? true : false);
        }


        [HttpGet]
        [Route("Zadatak13")]

        //Ruta prima dva parametra koji su cijeli brojevi te vraća dvodimenzionalni niz (matricu) cijelih brojeva koji su složeni prema slici zadatka: Ciklična matrica

        public String Zad13(int red, int stup) 
        {
            int a = 0;
            int b = 1;
            int c = 2;
            int d = 3;
            int x = 1;
            int i = 0;

            int[,] Matrica = new int[red, stup];
            StringBuilder SB = new StringBuilder();


            //Prvi krug
            for (i = 1; i <= stup; i++)
            {
                Matrica[red - 1, stup - i] = x++;
            }
            for (i = 2; i <= red; i++)
            {
                Matrica[red - i, 0] = x++;
            }
            for (i = 1; i < stup; i++)
            {
                if (red <= 1)
                {
                    break;
                }
                Matrica[0, i] = x++;
            }
            for (i = 1; i < red - 1; i++)
            {
                Matrica[i, stup - 1] = x++;
            }


            //Ostali krugovi
            int y = 1;
            for (y = 1; y < red && y < stup; y++)
            {
                if (red * stup == x + 1)
                {
                    break;
                }
                y++;


                for (i = c; i < stup - a; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[red - c, stup - i] = x++;
                }

                for (i = d; i < red - a; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[red - i, b] = x++;
                }

                for (i = c; i < stup - b; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[b, i] = x++;
                }

                for (i = c; i < red - c; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[i, stup - c] = x++;
                }
                a++;
                b++;
                c++;
                d++;
            }


            //Ispis matrice
            for (i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    SB.Append(Matrica[i, j] + "\t");
                }
                SB.AppendLine();
            }

            return SB.ToString();
        }
    }
}
