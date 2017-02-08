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
    public class UlogeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET api/UlogeDefault1
        public IQueryable<Uloge> GetUloges()
        {
            return db.Uloges.OrderBy(x=>x.Naziv);
        }

        // GET api/Uloge/5
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult GetUloge(int id)
        {
           
            Uloge uloge = db.Uloges.Find(id);
            if (uloge == null)
            {
                return NotFound();
            }

            return Ok(uloge);
        }

        //[HttpGet]
        //[Route("api/Korisnici/{id}/Uloge")]
        //public List<Uloge> GetUlogeByKorisnikId(int id)
        //{
        //  return db.esp_Uloge_SelectByKorisnikID(id).ToList();
            
        //}

        // PUT api/Uloge/5
        public IHttpActionResult PutUloge(int id, Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uloge.UlogaID)
            {
                return BadRequest();
            }

            db.Entry(uloge).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UlogeExists(id))
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

        // POST api/Uloge
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult PostUloge(Uloge uloge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uloges.Add(uloge);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = uloge.UlogaID }, uloge);
        }

        [HttpPost]
        //[ResponseType(typeof(Uloge))]
        [Route("api/Korisnici/AddUloge/{id}")]
        public void PostUlogeKorisnici(int korisnikID, List<Uloge> uloge)
        {
            foreach (Uloge item in uloge)
            {


                db.esp_KorisniciUloge_Insert(korisnikID, item.UlogaID);
            }
            
        }
        [HttpPost]
        //[ResponseType(typeof(Uloge))]
        [Route("api/Korisnici/DeleteUloge/{idu}")]
        public void DeleteUlogeKorisnici(int korisnikID, List<Uloge> uloge)
        {
            foreach (Uloge item in uloge)
            {

                db.esp_KorisniciUloge_Delete(korisnikID, item.UlogaID);
            }
        }
        // DELETE api/Uloge/5
        [ResponseType(typeof(Uloge))]
        public IHttpActionResult DeleteUloge(int id)
        {
            Uloge uloge = db.Uloges.Find(id);
            if (uloge == null)
            {
                return NotFound();
            }

            db.Uloges.Remove(uloge);
            db.SaveChanges();

            return Ok(uloge);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UlogeExists(int id)
        {
            return db.Uloges.Count(e => e.UlogaID == id) > 0;
        }
    }
}