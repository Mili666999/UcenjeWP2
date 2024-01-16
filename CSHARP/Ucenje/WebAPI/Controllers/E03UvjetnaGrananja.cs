using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnaGrananja : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]
        public string Zad1(int Broj)
        {
            // Za primljeni broj ruta vraća PARAN ili NEPARAN

            // Rješenje 1 Školski primjer
            //if (Broj % 2 == 0)
            //{
            //    return "PARAN";
            //}
            //else 
            //{
            //    return "NEPARAN";
            //}

            // Rješenje 2
            //if(Broj % 2 == 0)
            //{
            //    return "PARAN";
            //}
            //return "NEPARAN";

            // Rješenje 3
            return Broj % 2 == 0 ? "PARAN" : "NEPARAN";

            // Rješenje 4
            //return (Broj % 2 != 0 ? "NE" : "") + "PARAN";
        }

        [HttpGet]
        [Route("zad2")]
        public string OcjenaTekstom(int Ocjena)
        {
            // Za primljenu brojčanu vrijednost ocjene vratiti tekstualni reprezentant
            switch (Ocjena) 
            {
                case 1:
                    return "Nedovoljan";
                case 2:
                    return "Dovoljan";
                case 3:
                    return "Dobar";
                case 4:
                    return "Vrlo dobar";
                case 5:
                    return "Odličan";
            }
            return $"{Ocjena} nije ocjena";
        }
    }
}
