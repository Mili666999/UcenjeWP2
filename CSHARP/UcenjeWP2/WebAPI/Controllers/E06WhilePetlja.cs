using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E06")]
    public class E06WhilePetlja : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]
        public int[] Zad1(int Brojevi)
        {
            //Ruta vraća niz s brojevima od 1 do Brojevi
            int[]   Niz = new int[Brojevi];
            int i = 0;

            while (i++ < Brojevi)
            {
                Niz[i-1] = i;
            }
 
            return Niz;
        }


        [HttpGet]
        [Route("zad2")]
        public int Zad2(int Brojevi)
        {
            //Ruta vraća zbroj svih brojeva od 1 do unešenog broja
            int Suma = 0;
            int i = 0;

            while (i++ < Brojevi)
            {
                Suma += i;
            }

            return Suma;
        }





    }
}
