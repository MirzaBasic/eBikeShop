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
using PeP_API.Util;

namespace PeP_API.Controllers
{
    public class ProizvodiController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET api/Proizvodi
        public IQueryable<Proizvodi> GetProizvodis()
        {
            return db.Proizvodis;
        }

        // GET api/Proizvodi/5
        [HttpGet]
        [Route("api/Proizvodi/{id}")]
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult GetProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodis.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            return Ok(proizvodi);
        }


    



        [HttpGet]
        [ResponseType(typeof(Proizvodi_Result))]
        [Route("api/Proizvodi/SearchProizvodi/{nazivSifra?}")]
        public List<Proizvodi_Result> GetProizvodiByNazivSifra(string nazivSifra = "")
        {
            return db.esp_Proizvodi_SelectByNazivSifra(nazivSifra).ToList();
        }





        [HttpGet]
        [Route("api/Proizvodi/SelectByProizvodID/{proizvodID}")]
        [ResponseType(typeof(ProizvodiByID_Result))]
        public ProizvodiByID_Result SelectByID(int proizvodID)
        {
            return db.esp_Proizvodi_SelectById(proizvodID).FirstOrDefault();
        }


        [ResponseType(typeof(Proizvodi_Result))]
        [HttpGet]
        [Route("api/Proizvodi/RecomendedProduct/{proizvodID}")]
        public List<ProizvodiByID_Result> RecommendedProducts(int proizvodID)
        {
            Recommender r = new Recommender();
          return  r.GetSlicneProizvode(proizvodID);
        }

        // PUT api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        [Route("api/Proizvodi/{id?}")]
        public IHttpActionResult PutProizvodi(int id, Proizvodi p)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != p.ProizvodID)
            {
                return BadRequest();
            }


            db.esp_Proizvodi_Update(p.ProizvodID, p.Naziv, p.Sifra, p.Cijena, p.VrstaID, p.JedinicaMjereID, p.Slika, p.SlikaThumb, p.Status);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodiExists(id))
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
        [ResponseType(typeof(Proizvodi_Result))]
        [Route("api/Proizvodi/SearchProizvodiNazivVrsta/{vrstaID}/{nazivSifra?}")]
        public List<Proizvodi_Result> GetProizvodiByNazivSifraVrstaID(int vrstaID, string nazivSifra = "")
        {
            return db.esp_Proizvodi_SelectByNazivSifraVrstaID(nazivSifra, vrstaID).ToList();

        }


        // POST api/Proizvodi
        [HttpPost]
      [Route("api/Proizvodi")]
        [ResponseType(typeof(Proizvodi))]
        public void PostProizvodi(Proizvodi p)
        {
          
            db.esp_Proizvodi_Insert(p.Naziv, p.Sifra, p.Cijena, p.VrstaID, p.JedinicaMjereID, p.Slika, p.SlikaThumb);


          
        }




        [HttpGet]
        [Route("api/Proizvodi/StanjeNaSkladistu/{proizvodID}/{skladisteID}")]
        [ResponseType(typeof(int))]
        public int GetProizvodi(int proizvodID , int skladisteID )
        {
           return db.esp_Proizvodi_ProvjeraKolicine(proizvodID, skladisteID).FirstOrDefault().GetValueOrDefault(0);
          
        }


        [HttpGet]
        [Route("api/Proizvodi/SearchBySifra/{sifra}")]
        [ResponseType(typeof(Proizvodi))]
        public Proizvodi GetProizvodi(string sifra)
        {
            return db.esp_Proizvodi_SelectBySifra(sifra).FirstOrDefault();

        }


        // DELETE api/Proizvodi/5
        [ResponseType(typeof(Proizvodi))]
        public IHttpActionResult DeleteProizvodi(int id)
        {
            Proizvodi proizvodi = db.Proizvodis.Find(id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            db.Proizvodis.Remove(proizvodi);
            db.SaveChanges();

            return Ok(proizvodi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProizvodiExists(int id)
        {
            return db.Proizvodis.Count(e => e.ProizvodID == id) > 0;
        }
    }
}