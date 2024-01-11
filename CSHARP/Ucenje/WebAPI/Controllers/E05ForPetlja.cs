using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E05")]
    public class E05ForPetlja : ControllerBase
    {

        [HttpGet]
        [Route("Zad1")]
        public int[] Zad1(int Brojevi)
        {
            //Ruta vraća niz s brojevima od 1 do Brojevi
            int[]   Niz = new int[Brojevi];
            for(int i = 0; i < Brojevi; i++) 
            {
                Niz[i] = i+1;
            }
 
            return Niz;
        }


        [HttpGet]
        [Route("Zad2")]
        public int ZbrojBrojeva(int Broj)
        {
            //Ruta vraća zbroj primljenih brojeva
            int Zbroj = 0;
            for (int i = 1; i <= Broj; i++)
            { 
                Zbroj += i;
            }

            return Zbroj;
        }

        
    }
}
