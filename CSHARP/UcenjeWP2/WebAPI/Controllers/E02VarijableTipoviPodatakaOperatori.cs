using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            // Vratite najmanji broj
            return int.MinValue;
        }

        [HttpGet]
        [Route("zad2")]
        public float Zad2(int i, int j)
        {
            // Ruta vraća kvocijent dvaju primljenih brojeva
            float Rezultat = (float)i /j;
            return Rezultat;
        }

        [HttpGet]
        [Route("zad3")]
        public float Zad3(int i, int j)
        {
            // Ruta vraća zbroj umnoška i kvocijenta dvaju primljenih brojeva
            //return (float)(i * j) + (float)(i / j);
            var Umnozak = i * j; // Var je ključna riječ koja preuzima tip podatka s desne strane znaka jednakosti "="
            var Kvocijent = (float)i /j;
            return Umnozak / Kvocijent;
            
        }

        [HttpGet]
        [Route("zad4")]
        public string Zad4(string s, string s1)
        {
            // Ruta vraća spojene primljene znakove
            return s + s1;

        }

        [HttpGet]
        [Route("zad5")]
        public bool IstiSu(int a, int b)
        {
            // Ruta vraća True ako je a=b, inače vraća false
            return a == b;
        }

    }
}
