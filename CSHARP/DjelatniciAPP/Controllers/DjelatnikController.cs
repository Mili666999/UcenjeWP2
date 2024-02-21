using DjelatniciAPP.Data;
using DjelatniciAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DjelatniciAPP.Controllers
{
    /// <summary>
    /// Namjenjeno za CRUD operacije nad entitetom djelatnik u bazi
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DjelatnikController : ControllerBase
    {
        /// <summary>
        /// Kontekst za rad s bazom koji će biti postavljen pomoću Dependency Injectiona
        /// </summary>
        private readonly DjelatniciContext _context;

        /// <summary>
        /// Konstrukotr klase koja prima Djelatnici context pomoću DI
        /// </summary>
        /// <param name="context"></param>
        public DjelatnikController(DjelatniciContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve djelatnike iz baze
        /// </summary>
        /// <remarks>
        /// Primjer upita
        ///     
        ///     GET api/vi/Djelatnik
        /// 
        /// </remarks>
        /// <returns>Djelatnici u bazi</returns>
        /// <response code="200">Sve OK, ako nema podataka content length - 0</response>
        /// <response code="400">Zahtjev nije valjan</response>
        /// <response code="503">Baza na koju se spajam nije dostupna</response>
        [HttpGet]
        public IActionResult Get()
        {
            //Kontrola ukoliko upit nije valjan
            if (!ModelState.IsValid)
            { 
                return BadRequest(ModelState);
            }

            try 
            {
                var Djelatnici = _context.Djelatnici.ToList();
                if(Djelatnici == null || Djelatnici.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(Djelatnici);
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, ex.Message);
            }

        }
    }
}
