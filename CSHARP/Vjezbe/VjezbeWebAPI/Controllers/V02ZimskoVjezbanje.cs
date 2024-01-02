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
    }
}
