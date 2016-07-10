
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralModels
{
    public class GameChess
    {
         public GameChess()
        {
            //Level l1 = new Level(); not available since it different assemby
            Game g = new Game();
            Game.a = 555;
            
        }
    }
}
