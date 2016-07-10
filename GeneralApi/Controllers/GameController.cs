using System;
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
       
        public async Task<HttpResponseMessage> GetGames(Guid gameId)
        {
            if (!ModelState.IsValid)
            {
                var gs = new ServiceResponse<Game>() { Code = 500, Data = null };
                return GenericResponse(gs); //geberarsytfys sdihiusd

            }
            else
            {
                //await Task.Delay(5000);
                var retData = new Game() { GameId = new Guid(), GameName = "New Game" };
               
                     var gs = new ServiceResponse<Game>() { Code = 200, Data = retData };
                return GenericResponse(gs);
               //return  await Task.Run(() => { return GenericResponse(gs); });
         

            }
        }
    }
}
