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
    public class NarudzbeController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET: api/Narudzbe
        public IQueryable<Narudzbe> GetNarudzbes()
        {
            return db.Narudzbes;
        }


        [Route("api/Narudzbe/SelectAktivne/{datum?}")]
        [ResponseType(typeof(Narudzbe_Result))]
        public List<Narudzbe_Result> GetNarudzbe(string datum = "")
        {
            return db.esp_Narudzbe_SelectAktivne(datum).ToList();
        }



        [HttpPut]
        [Route("api/Narudzbe/OtkaziNarudzbu/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult OtkaziNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaID)
            {
                return BadRequest();
            }

            db.esp_Narudzbe_OtkaziByID(id);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
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


        [HttpGet]
        [Route("api/Narudzbe/SelectAktivneByKupacID/{id}")]
       
        public List<Narudzbe> GetNarudzbeBaKorisnikID(int id)
        {
            return db.esp_Narudzbe_SelectAktivneByKupacID(id).ToList();
        }

        [HttpGet]
        [Route("api/Narudzbe/GetBrojAktivnihNarudzbi")]
        public int GetBrojAktivnihNarudzbi() {
            return db.Narudzbes.Where(x => x.Status == true).Count();
        }

        [Route("api/Narudzbe/SelectProizvodiStavke/{id}")]
        [ResponseType(typeof(ProizvodiStavke_Result))]
        public List<ProizvodiStavke_Result> GetStavkeProizvodi(int id)
        {
            return db.esp_Proizvodi_SelectByNarudzbaID(id).ToList();
        }


        [Route("api/Narudzbe/SelectStavke/{id}")]
        [ResponseType(typeof(NarudzbeStavke_Result))]
        public List<NarudzbeStavke_Result> GetStavkeNarudzbe(int id)
        {
            return db.esp_NarudzbeStavke_SelectByNarudzbaID(id).ToList();
        }
        // GET: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe_Result))]
        public IHttpActionResult GetNarudzbe(int id)
        {
            Narudzbe_Result narudzbe = db.esp_Narudzbe_SelectByID(id).FirstOrDefault();
            if (narudzbe == null)
            {
                return NotFound();
            }

            return Ok(narudzbe);
        }

        // PUT: api/Narudzbe/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNarudzbe(int id, Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != narudzbe.NarudzbaID)
            {
                return BadRequest();
            }

            db.Entry(narudzbe).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NarudzbeExists(id))
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

        // POST: api/Narudzbe
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult PostNarudzbe(Narudzbe narudzbe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            narudzbe.NarudzbaID = Convert.ToInt32(db.esp_Narudzbe_Insert(narudzbe.BrojNarudzbe, narudzbe.KupacID, narudzbe.Datum).FirstOrDefault());
            foreach (NarudzbaStavke item in narudzbe.NarudzbaStavkes)
            {

                db.esp_NarudzbaStavke_Insert(narudzbe.NarudzbaID, item.ProizvodID, item.Kolicina);
            }
          

            return CreatedAtRoute("DefaultApi", new { id = narudzbe.NarudzbaID }, narudzbe);
        }

        // DELETE: api/Narudzbe/5
        [ResponseType(typeof(Narudzbe))]
        public IHttpActionResult DeleteNarudzbe(int id)
        {
            Narudzbe narudzbe = db.Narudzbes.Find(id);
            if (narudzbe == null)
            {
                return NotFound();
            }

            db.Narudzbes.Remove(narudzbe);
            db.SaveChanges();

            return Ok(narudzbe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NarudzbeExists(int id)
        {
            return db.Narudzbes.Count(e => e.NarudzbaID == id) > 0;
        }



        
    }
}