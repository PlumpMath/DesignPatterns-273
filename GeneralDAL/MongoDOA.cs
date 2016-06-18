using GeneralModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDAL
{
 
    public class MongoDOA
    {
        MongoServer server;
        public MongoDOA()
        {
            MongoServerSettings mss = new MongoServerSettings()
            {
                Server = new MongoServerAddress("127.0.0.1", 27017)
            };
            server = new MongoServer(mss);
             var db = server.GetDatabase("blog");
            var collection = db.GetCollection<Game>("Game");
        }
        
    }
}
