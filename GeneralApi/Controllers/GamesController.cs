//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Http.ModelBinding;
//using System.Web.Http.OData;
//using System.Web.Http.OData.Routing;
//using GeneralDAL;

//namespace GeneralApi.Controllers
//{
//    /*
//    The WebApiConfig class may require additional changes to add a route for this controller. 
//Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

//    using System.Web.Http.OData.Builder;
//    using System.Web.Http.OData.Extensions;
//    using GeneralDAL;
//    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
//    builder.EntitySet<Games>("Games");
//    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
//    */
//    [RoutePrefix("api/Games")]
//    public class GamesController : ODataController
//    {
//        private GeneralDBEntities db = new GeneralDBEntities();

//        // GET: odata/Games
//        [Route("Games")]
//        [EnableQuery]
//        public IQueryable<Games> GetGames()
//        {
//            return db.Games;
//        }

//        // GET: odata/Games(5)
//        [EnableQuery]
//        public SingleResult<Games> GetGames([FromODataUri] Guid key)
//        {
//            return SingleResult.Create(db.Games.Where(games => games.GameId == key));
//        }

//        // PUT: odata/Games(5)
//        public async Task<IHttpActionResult> Put([FromODataUri] Guid key, Delta<Games> patch)
//        {
//            Validate(patch.GetEntity());

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            Games games = await db.Games.FindAsync(key);
//            if (games == null)
//            {
//                return NotFound();
//            }

//            patch.Put(games);

//            try
//            {
//                await db.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!GamesExists(key))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return Updated(games);
//        }

//        // POST: odata/Games
//        [Route("Create")]
//        [EnableQuery]
//        public async Task<IHttpActionResult> Post(Games games)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            db.Games.Add(games);

//            try
//            {
//                await db.SaveChangesAsync();
//            }
//            catch (DbUpdateException)
//            {
//                if (GamesExists(games.GameId))
//                {
//                    return Conflict();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return Created(games);
//        }

//        // PATCH: odata/Games(5)
//        [AcceptVerbs("PATCH", "MERGE")]
//        public async Task<IHttpActionResult> Patch([FromODataUri] Guid key, Delta<Games> patch)
//        {
//            Validate(patch.GetEntity());

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            Games games = await db.Games.FindAsync(key);
//            if (games == null)
//            {
//                return NotFound();
//            }

//            patch.Patch(games);

//            try
//            {
//                await db.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!GamesExists(key))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return Updated(games);
//        }

//        // DELETE: odata/Games(5)
//        [Route("DeleteGame")]
//        public async Task<IHttpActionResult> Delete([FromODataUri] Guid key)
//        {
//            Games games = await db.Games.FindAsync(key);
//            if (games == null)
//            {
//                return NotFound();
//            }

//            db.Games.Remove(games);
//            await db.SaveChangesAsync();

//            return StatusCode(HttpStatusCode.NoContent);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private bool GamesExists(Guid key)
//        {
//            return db.Games.Count(e => e.GameId == key) > 0;
//        }
//    }
//}
