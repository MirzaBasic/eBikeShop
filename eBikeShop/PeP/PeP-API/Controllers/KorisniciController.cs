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
using System.Data.Entity.Core;
using PeP_API.Util;

namespace PeP_API.Controllers
{
    [ExceptionFilter]
    public class KorisniciController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET api/Korisnici
        public IQueryable<Korisnici> GetKorisnicis()
        {
            return db.Korisnicis;
        }

        // GET api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult GetKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnicis.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{username}")]
        public IHttpActionResult GetKorisnici(string username)
        {

            Korisnici korisnici = db.Korisnicis.Where(x => x.KorisnickoIme == username).FirstOrDefault();
            if (korisnici == null)
            {
                return NotFound();
            }

            return Ok(korisnici);
        }

        // PUT api/Korisnici/5
          
        [ResponseType(typeof(Korisnici))]
        [Route("api/Korisnici/{id}")]
        public IHttpActionResult PutKorisnici(int id, Korisnici k)
        {




            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != k.KorisnikID)
            {
                return BadRequest();
            }

            db.esp_Korisnici_Update(k.KorisnikID, k.Ime, k.Prezime, k.Email, k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash, k.Status);
           
           

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisniciExists(id))
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

        // POST api/Korisnici
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult PostKorisnici(Korisnici k)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Korisnicis.Add(korisnici);
            //db.SaveChanges();
            try
            {
                k.KorisnikID = Convert.ToInt32(db.esp_Korisnici_Insert(k.Ime, k.Prezime, k.Email, k.Telefon, k.KorisnickoIme, k.LozinkaSalt, k.LozinkaHash).FirstOrDefault());
            }
            catch (EntityException ex)
            {
                //throw new NotImplementedException();
               throw CreateHttpResponseException (Util.ExceptionHandler.HandleException(ex), HttpStatusCode.Conflict);


            }

            foreach (Uloge u in k.Uloge)
            {

                db.esp_KorisniciUloge_Insert(k.KorisnikID, u.UlogaID);
            }
            return CreatedAtRoute("DefaultApi", new { id = k.KorisnikID }, k);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode status)
        {
            HttpResponseMessage msg = new HttpResponseMessage()
            {

                StatusCode = status,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };
            return new HttpResponseException(msg);
        }

       

        // DELETE api/Korisnici/5
        [ResponseType(typeof(Korisnici))]
        public IHttpActionResult DeleteKorisnici(int id)
        {
            Korisnici korisnici = db.Korisnicis.Find(id);
            if (korisnici == null)
            {
                return NotFound();
            }

            db.Korisnicis.Remove(korisnici);
            db.SaveChanges();

            return Ok(korisnici);
        }

        [HttpGet]
        [Route("api/Korisnici/SearchKorisnici/{name?}")]
        public List<Korisnici> SearchKorisnici(string name="")
        {
            return db.esp_Korisnici_SelectByImePrezime(name).ToList();

        }


        [HttpGet]
        [Route("api/Korisnici/SearchKorisniciById/{id?}")]
        public Korisnici SearchKorisnici(int id)
        {
            return db.esp_KorisniciSelectById(id).FirstOrDefault();

        }


        [HttpGet]
        [Route("api/Korisnici/{id}/Uloge")]
        public List<Uloge> GetUlogeByKorisnikId(int id)
        {
            return db.esp_Uloge_SelectByKorisnikID(id).ToList();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KorisniciExists(int id)
        {
            return db.Korisnicis.Count(e => e.KorisnikID == id) > 0;
        }
    }
}