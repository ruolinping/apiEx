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
using apiEx.Models;

namespace apiEx.Controllers
{
    public class tblRoadsController : ApiController
    {
        private RoadsEntities db = new RoadsEntities();

        // GET: api/tblRoads
        public IQueryable<tblRoad> GettblRoads()
        {
            return db.tblRoads;
        }

        // GET: api/tblRoads/5
        [ResponseType(typeof(tblRoad))]
        public IHttpActionResult GettblRoad(int id)
        {
            tblRoad tblRoad = db.tblRoads.Find(id);
            if (tblRoad == null)
            {
                return NotFound();
            }

            return Ok(tblRoad);
        }

        // PUT: api/tblRoads/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblRoad(int id, tblRoad tblRoad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblRoad.BIA_No)
            {
                return BadRequest();
            }

            db.Entry(tblRoad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblRoadExists(id))
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

        // POST: api/tblRoads
        [ResponseType(typeof(tblRoad))]
        public IHttpActionResult PosttblRoad(tblRoad tblRoad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblRoads.Add(tblRoad);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tblRoadExists(tblRoad.BIA_No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblRoad.BIA_No }, tblRoad);
        }

        // DELETE: api/tblRoads/5
        [ResponseType(typeof(tblRoad))]
        public IHttpActionResult DeletetblRoad(int id)
        {
            tblRoad tblRoad = db.tblRoads.Find(id);
            if (tblRoad == null)
            {
                return NotFound();
            }

            db.tblRoads.Remove(tblRoad);
            db.SaveChanges();

            return Ok(tblRoad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblRoadExists(int id)
        {
            return db.tblRoads.Count(e => e.BIA_No == id) > 0;
        }
    }
}