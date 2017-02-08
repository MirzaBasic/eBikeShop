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
    public class DobavljaciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Dobavljaci
        public IQueryable<Dobavljaci> GetDobavljacis()
        {
            return db.Dobavljacis;
        }

        // GET: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult GetDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljacis.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            return Ok(dobavljaci);
        }


        [ResponseType(typeof(Dobavljaci))]
        [HttpGet]
        [Route("api/Dobavljaci/Search/{naziv?}")]
        public List<Dobavljaci> GetProizvodiByNazivSifra(string naziv = "")
        {
            return db.esp_Dobavljaci_SelectByNaziv(naziv).ToList();
        }

        // PUT: api/Dobavljaci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDobavljaci(int id, Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dobavljaci.DobavljacID)
            {
                return BadRequest();
            }

            db.Entry(dobavljaci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DobavljaciExists(id))
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

        // POST: api/Dobavljaci
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult PostDobavljaci(Dobavljaci dobavljaci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dobavljacis.Add(dobavljaci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dobavljaci.DobavljacID }, dobavljaci);
        }

        // DELETE: api/Dobavljaci/5
        [ResponseType(typeof(Dobavljaci))]
        public IHttpActionResult DeleteDobavljaci(int id)
        {
            Dobavljaci dobavljaci = db.Dobavljacis.Find(id);
            if (dobavljaci == null)
            {
                return NotFound();
            }

            db.Dobavljacis.Remove(dobavljaci);
            db.SaveChanges();

            return Ok(dobavljaci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DobavljaciExists(int id)
        {
            return db.Dobavljacis.Count(e => e.DobavljacID == id) > 0;
        }
    }
}