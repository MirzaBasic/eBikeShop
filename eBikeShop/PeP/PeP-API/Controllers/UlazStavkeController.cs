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
    public class UlazStavkeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/UlazStavke
        public IQueryable<UlazStavke> GetUlazStavkes()
        {
            return db.UlazStavkes;
        }

        // GET: api/UlazStavke/5
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult GetUlazStavke(int id)
        {
            UlazStavke ulazStavke = db.UlazStavkes.Find(id);
            if (ulazStavke == null)
            {
                return NotFound();
            }

            return Ok(ulazStavke);
        }

        // PUT: api/UlazStavke/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUlazStavke(int id, UlazStavke ulazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ulazStavke.UlazStavkaID)
            {
                return BadRequest();
            }

            db.Entry(ulazStavke).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlazStavkeExists(id))
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

        // POST: api/UlazStavke
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult PostUlazStavke(UlazStavke ulazStavke)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UlazStavkes.Add(ulazStavke);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ulazStavke.UlazStavkaID }, ulazStavke);
        }

        // DELETE: api/UlazStavke/5
        [ResponseType(typeof(UlazStavke))]
        public IHttpActionResult DeleteUlazStavke(int id)
        {
            UlazStavke ulazStavke = db.UlazStavkes.Find(id);
            if (ulazStavke == null)
            {
                return NotFound();
            }

            db.UlazStavkes.Remove(ulazStavke);
            db.SaveChanges();

            return Ok(ulazStavke);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlazStavkeExists(int id)
        {
            return db.UlazStavkes.Count(e => e.UlazStavkaID == id) > 0;
        }
    }
}