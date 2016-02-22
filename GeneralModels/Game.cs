using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralModels
{
    public class Game
    {
        [JsonProperty("gameId")]
        public Guid GameId { get; set; }
        [JsonProperty("gameName")]
        public string GameName { get; set; }
    }
}
