﻿using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Controllers
{
    /// <summary>
    /// Namjenjeno za CRUD operacije nad entitetom Smjer u bazi
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController : ControllerBase
    {
        /// <summary>
        /// Kontekst za rad s bazom koji će biti postavljen s pomoću Dependency Injection-om
        /// </summary>
        private readonly EdunovaContext _context;

        /// <summary>
        /// Konstruktor klase koja prima Edunova kontekst
        /// pomoću DI principa
        /// </summary>
        /// <param name="context"></param>
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve smjerove iz baze
        /// </summary>
        ///<remarks>
        ///Primjer upita 
        /// 
        ///     GET api/v1/Smjer
        ///     
        /// </remarks>
        /// <returns>Smjerovi u bazi</returns>
        /// <response code="200">Sve OK, ako nema podataka: contetn-length 0</response>
        /// <response code="400">Zahtjev nije valjan</response>
        /// <response code="503">Baza na koju se spajam nije dostupna</response>
        [HttpGet]
        public IActionResult Get()
        {
            // kontrola ukoliko upit nije valjan
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var smjerovi = _context.Smjerovi.ToList();
                if (smjerovi == null || smjerovi.Count == 0)
                {
                    return new EmptyResult();
                }
                return new JsonResult(smjerovi);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }

        /// <summary>
        /// Dodaje novi smjer u bazu
        /// </summary>
        /// <remarks>
        ///     POST api/v1/Smjer
        ///     {naziv: "Primjer naziva"}
        /// </remarks>
        /// <param name="smjer">Smjer za unijeti u JSON formatu</param>
        /// <response code="201">Kreirano</response>
        /// <response code="400">Zahtjev nije valjan (BadRequest)</response>
        /// <response code="503">Baza nedostupna iz rzno raznih razloga</response>
        /// <returns>Smjer sa šifrom koju je dala baza</returns>
        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            if (!ModelState.IsValid || smjer == null)
            {
                return BadRequest();
            }
            try
            {
                _context.Smjerovi.Add(smjer);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, smjer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }

        /// <summary>
        /// Mijenja podatke postojećeg smjera u bazi
        /// </summary>
        /// <remarks>
        /// Primjer upita:
        ///
        ///    PUT api/v1/smjer/1
        ///
        /// {
        ///  "sifra": 0,
        ///  "naziv": "Novi naziv",
        ///  "trajanje": 120,
        ///  "cijena": 890.22,
        ///  "upisnina": 0,
        ///  "verificiran": true
        /// }
        ///
        /// </remarks>
        /// <param name="sifra">Šifra smjera koji se mijenja</param>  
        /// <param name="smjer">Smjer za unijeti u JSON formatu</param>  
        /// <returns>Svi poslani podaci od smjera koji su spremljeni u bazi</returns>
        /// <response code="200">Sve je u redu</response>
        /// <response code="204">Nema u bazi smjera kojeg želimo promijeniti</response>
        /// <response code="415">Nismo poslali JSON</response> 
        /// <response code="503">Baza nedostupna</response> 
        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, Smjer smjer)
        {
            if (sifra <= 0 || !ModelState.IsValid || smjer == null)
            {
                return BadRequest();
            }

            
            try
            {
                var SmjerIzBaze = _context.Smjerovi.Find(sifra);

                if (SmjerIzBaze == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent,sifra);
                }

                //Inače ovo rade mapperi
                //Za sada ručno
                SmjerIzBaze.Naziv = smjer.Naziv;
                SmjerIzBaze.Trajanje = smjer.Trajanje;
                SmjerIzBaze.Cijena = smjer.Cijena;
                SmjerIzBaze.Upisnina = smjer.Upisnina;
                SmjerIzBaze.Verificiran = smjer.Verificiran;

                _context.Smjerovi.Update(SmjerIzBaze);
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, SmjerIzBaze);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }

        }

        /// <summary>
        /// Briše smjer iz baze
        /// </summary>
        /// <remarks>
        /// Primjer upita:
        ///
        ///    DELETE api/v1/smjer/1
        ///    
        /// </remarks>
        /// <param name="sifra">Šifra smjera koji se briše</param>  
        /// <returns>Odgovor da li je obrisano ili ne</returns>
        /// <response code="200">Sve je u redu, obrisano je u bazi</response>
        /// <response code="204">Nema u bazi smjera kojeg želimo obrisati</response>
        /// <response code="503">Problem s bazom</response> 
        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int sifra)
        {
            if (!ModelState.IsValid || sifra <= 0)
            { 
                return BadRequest();
            }

            try
            {
                var SmjerIzBaze = _context.Smjerovi.Find(sifra);

                if (SmjerIzBaze == null)
                {
                    return StatusCode(StatusCodes.Status204NoContent, sifra);
                }

                _context.Smjerovi.Remove(SmjerIzBaze);
                _context.SaveChanges();

                return new JsonResult("{\"poruka\" : \"Obrisano\"}"); //Ovo nije najbolja praksa, ali da znamo da može i ovako
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,
                    ex.Message);
            }
        }
    }
}
