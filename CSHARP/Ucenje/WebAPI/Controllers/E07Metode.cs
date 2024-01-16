using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E07")]
    public class E07Metode : ControllerBase
    {

        [HttpGet]
        [Route("zad1")]

        //Napisati metodu koja za dva primljena cijela broja vraća njihov zbroj
        //Neka metoda Zad1 vrati rezultat napisane metode zadatka

        public int Zad1(int PrviBroj, int DrugiBroj)
        {


            return Zbroj(PrviBroj, DrugiBroj);
        }

        private int Zbroj(int prviBroj, int drugiBroj)
        {
            return prviBroj + drugiBroj;
        }

        
        //Kreirati rutu zad2 koja prima 4 cijela broja i vraća razliku (prvi + drugi) - (treći + četvrti)
        //Koristiti kreiranu metodu (Zbroj) za zbroj dvaju brojeva

        [HttpGet]
        [Route("zad2")]

        public float Zad2(int Prvi, int Drugi, int Treci, int Cetvrti)
        { 
            return Zbroj(Prvi, Drugi) - Zbroj(Treci, Cetvrti);
        }


        //Kreirati rutu zad3 koja prima ime grada i slovo
        //Ruta vraća broj pojavljivanja slova u primljenom imenu grada

        [HttpGet]
        [Route("zad3")]

        public int Zad3(string Grad, char Slovo)
        {
            return Brojac(Grad, Slovo);
        }

        private int Brojac(string Grad, char Slovo)
        {
            int Zbroj = 0;

            foreach (char c in Grad)
            {
                if (c == Slovo)
                { 
                    Zbroj++;
                }
            }

            return Zbroj;
        }
    }
}
