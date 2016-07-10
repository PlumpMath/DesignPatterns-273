using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralModels
{
   // [Serializable]
    public class Game
    {
        public ObjectId Id { get; set; }

        [JsonProperty("gameId")]
        public Guid GameId { get; set; }
        [JsonProperty("gameName")]
        public string GameName { get; set; }


        internal static int a = 0;

        public Game()
        {
            Level l1 = new Level();
        }
    }
}
