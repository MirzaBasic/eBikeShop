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
    public class IzlaziController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Izlazi
        public IQueryable<Izlazi> GetIzlazis()
        {
            return db.Izlazis;
        }

        // GET: api/Izlazi/5
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult GetIzlazi(int id)
        {
            Izlazi izlazi = db.Izlazis.Find(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            return Ok(izlazi);
        }

        // PUT: api/Izlazi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIzlazi(int id, Izlazi izlazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != izlazi.IzlazID)
            {
                return BadRequest();
            }

            db.Entry(izlazi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IzlaziExists(id))
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

        // POST: api/Izlazi
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult PostIzlazi(Izlazi izlazi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.esp_Izlazi_InsertByNarudzbaID(izlazi.NarudzbaID, izlazi.IznosSaPDV, izlazi.IznosBezPDV, izlazi.SkladisteID, izlazi.KorisnikID);

            return CreatedAtRoute("DefaultApi", new { id = izlazi.IzlazID }, izlazi);
        }

        // DELETE: api/Izlazi/5
        [ResponseType(typeof(Izlazi))]
        public IHttpActionResult DeleteIzlazi(int id)
        {
            Izlazi izlazi = db.Izlazis.Find(id);
            if (izlazi == null)
            {
                return NotFound();
            }

            db.Izlazis.Remove(izlazi);
            db.SaveChanges();

            return Ok(izlazi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IzlaziExists(int id)
        {
            return db.Izlazis.Count(e => e.IzlazID == id) > 0;
        }
    }
}