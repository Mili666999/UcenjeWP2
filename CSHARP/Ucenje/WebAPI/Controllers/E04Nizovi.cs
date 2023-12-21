using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Nizovi : ControllerBase
    {

        [HttpPost]
        [Route("Zad1")]
        public string Zad1(string[] Podaci)
        {
            // Varti prvi element primljenog niza
            
            return Podaci[0];
        }

        [HttpPut]
        [Route("Zad2")]
        public int Zad2(string[] Podaci)
        {
            // Ruta prima cijele brojeve kao nizove znakova
            // Ruta će primiti 3 boja i vratiti najveći
            
            var B1 = int.Parse(Podaci[0]);
            var B2 = int.Parse(Podaci[1]);
            var B3 = int.Parse(Podaci[2]);

            // B1
            if (B1 >= B2 && B1 >= B3)
            {
                return B1;
            }
            // B2
            if (B2 >= B1 && B2 >= B3)
            {
                return B2;
            }
            // B3
            return B3;
        }

        [HttpDelete]
        [Route("Zad3")]
        public string BrojElemenataNiza(int[] Podaci)
        {
            // Ruta vraća broj elemenata niza kao string
            
            //return "" + Podaci.Count();
            //return $"{Podaci.Count()}";
            return Podaci.Count().ToString();
        }
    }
}
