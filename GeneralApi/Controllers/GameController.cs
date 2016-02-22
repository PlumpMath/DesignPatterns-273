using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using GeneralModels;

namespace GeneralApi.Controllers
{
    [RoutePrefix("api/games")]
    public class GameController : BaseController
    {
        [HttpGet]
        [Route("getGames/{gameId}")]
        public async Task<HttpResponseMessage> GetGames(Guid GameId)
        {
            if (!ModelState.IsValid)
            {
                ServiceResponse<Game> gs = new ServiceResponse<Game>() { Code = 500, Data = null };
                return GenericResponse(gs); //geberarsytfys sdihiusd

            }
            else
            {
                await Task.Delay(5000);
                Game RetData = new Game() { GameId = new Guid(), GameName = "New Game" };
                ServiceResponse<Game> gs = new ServiceResponse<Game>() { Code = 200, Data = RetData };
                //return GenericResponse<Game>(gs);
               return  await Task.Run(() => { return GenericResponse<Game>(gs); });
         

            }
        }
    }
}
