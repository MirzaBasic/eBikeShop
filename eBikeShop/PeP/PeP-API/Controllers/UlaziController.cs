using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PeP_API.Models;

namespace PeP_API.Controllers
{
    public class UlaziController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Ulazi
        public IQueryable<Ulazi> GetUlazis()
        {
            return db.Ulazis;
        }

        // GET: api/Ulazi/5
        [ResponseType(typeof(Ulazi))]
        public IHttpActionResult GetUlazi(int id)
        {
            Ulazi ulazi = db.Ulazis.Find(id);
            if (ulazi == null)
            {
                return NotFound();
            }

            return Ok(ulazi);
        }

        // PUT: api/Ulazi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUlazi(int id, Ulazi ulazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulazi.UlazID)
            {
                return BadRequest();
            }

            db.Entry(ulazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlaziExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

       

        [HttpPost]
        [Route("api/Ulazi")]
        [ResponseType(typeof(Ulazi))]
        public int PostUlazi(Ulazi u)
        {

         return db.esp_UlaziInsert(u.BrojFakture, u.Datum, u.IznosRacuna, u.PDV, u.Napomena, u.SkladisteID,u.KorisnikID,u.DobavljacID).First().GetValueOrDefault(0); ;
          
        }

        // DELETE: api/Ulazi/5
        [ResponseType(typeof(Ulazi))]
        public IHttpActionResult DeleteUlazi(int id)
        {
            Ulazi ulazi = db.Ulazis.Find(id);
            if (ulazi == null)
            {
                return NotFound();
            }

            db.Ulazis.Remove(ulazi);
            db.SaveChanges();

            return Ok(ulazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlaziExists(int id)
        {
            return db.Ulazis.Count(e => e.UlazID == id) > 0;
        }
    }
}