using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneralDAL;
using GeneralModels;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMongo()
        {
            MongoDOA doa = new MongoDOA();
            doa.getAll<Game>();
        }

        [TestMethod]
        public void InsertGame()
        {
            Game g = new Game() { GameId = Guid.NewGuid(), GameName = "Game Test" };
            MongoDOA doa = new MongoDOA();
            var ret = doa.insertObject<Game>(g);

           
        }
    }
}
