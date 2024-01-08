using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace VjezbeWebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01 : ControllerBase
    {
        [HttpGet]
        [Route("Zadatak1")]

        //Ruta prima tri parametra: dva cijela broja i string. String može biti + - * i /. Ruta vraća rezultat
        public float Zad1(int A, int B, string Operator)
        {
            switch (Operator)
            {
                case "+":
                    return A + B;
                    break;
                case "-":
                    return A - B;
                    break;
                case "*":
                    return A * B;
                    break;
                case "/":
                    return (float)A / B;
                    break;
            }
            return 0;
        }

        [HttpPost]
        [Route("Zadatak2 - NEDOVRŠEN")]

        //Ruta prima niz decimalnih brojeva. Vraća zbroj cijelog dijela prvog elementa niza i decimalnog dijela zadnjeg elementa niza
        public float Zad2(float[] Niz)
        {
            return 0;
        }
    }
}
