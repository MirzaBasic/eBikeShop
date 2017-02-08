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
    public class KupciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Kupci
        public IQueryable<Kupci> GetKupcis()
        {
            return db.Kupcis;
        }

        // GET: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupci(int id)
        {
            Kupci kupci = db.Kupcis.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }

        [HttpGet]
        [Route("api/Proizvodi/SelectByID/{id}")]
        [ResponseType(typeof(ProizvodiByID_Result))]
        public IHttpActionResult GetProizvodiByID(int id)
        {
            ProizvodiByID_Result proizvodi = db.esp_Proizvodi_SelectById(id).FirstOrDefault();
            if (proizvodi == null)
            {
                return NotFound();
            }

            return Ok(proizvodi);
        }


        // GET: api/Kupci/username
        [HttpGet]
        [Route("api/Kupci/GetUserByUsername/{username?}")]
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult GetKupciByUsername(string username)
        {
            Kupci kupci = db.Kupcis.Where(x => x.KorisnickoIme == username && x.Status == true).FirstOrDefault();
            if (kupci == null)
            {
                return NotFound();
            }

            return Ok(kupci);
        }

        // PUT: api/Kupci/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKupci(int id, Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupci.KupacID)
            {
                return BadRequest();
            }

            db.Entry(kupci).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KupciExists(id))
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

        // POST: api/Kupci
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult PostKupci(Kupci kupci)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kupcis.Add(kupci);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = kupci.KupacID }, kupci);
        }

        // DELETE: api/Kupci/5
        [ResponseType(typeof(Kupci))]
        public IHttpActionResult DeleteKupci(int id)
        {
            Kupci kupci = db.Kupcis.Find(id);
            if (kupci == null)
            {
                return NotFound();
            }

            db.Kupcis.Remove(kupci);
            db.SaveChanges();

            return Ok(kupci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KupciExists(int id)
        {
            return db.Kupcis.Count(e => e.KupacID == id) > 0;
        }
    }
}