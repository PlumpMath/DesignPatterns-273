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
        private readonly string instanceName;
        public MongoDOA()
        {
            MongoServerSettings mss = new MongoServerSettings()
            {
                Server = new MongoServerAddress("127.0.0.1", 27017)
            };
            instanceName = "Lottory";
            server = new MongoServer(mss);
            
        }

        public MongoCollection<T> getAll<T>()
        {
            var db = server.GetDatabase(instanceName);
            var collection = db.GetCollection<T>("Game");
           
            return collection;
        }
        
        public T insertObject<T>(T newInstance)
        {
            var db = server.GetDatabase(instanceName);
            var collection = db.GetCollection<T>("Game");
            var retVal = collection.Save(newInstance);
            return newInstance;

        }
    }
}
