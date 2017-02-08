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
    public class JediniceMjereController : ApiController
    {
        private eProdajaEntities db = new eProdajaEntities();

        // GET api/JediniceMjere
        public IQueryable<JediniceMjere> GetJediniceMjeres()
        {
            return db.JediniceMjeres;
        }

       

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