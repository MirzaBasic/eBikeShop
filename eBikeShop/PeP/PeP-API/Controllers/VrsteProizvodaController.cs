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
    public class VrsteProizvodaController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET api/VrsteProizvoda
        public IQueryable<VrsteProizvoda> GetVrsteProizvodas()
        {
            return db.VrsteProizvodas;
        }

        // GET api/VrsteProizvoda/5
    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

     
    }
}