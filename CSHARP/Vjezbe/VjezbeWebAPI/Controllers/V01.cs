using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace VjezbeWebAPI.Controllers
{
    [ApiController]
    [Route("V01")]
    public class V01 : ControllerBase
    {
        [HttpGet]
        [Route("Vjezba1")]

        public float Vjz1(int A, int B, string Operator)
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

        [HttpGet]
        [Route("Vjezba2")]

        public float Vjz2(float A, float B) 
        {
            return 0;
        }
    }
}
