using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.ChainOfResponsibility
{
    class ConcreteHandler3 : Handler
    {
        public override void handleRequest(int a)
        {
           if(a>-21)
            {
                Console.Write(string.Format("Concretehandler3 handleRequest {0}", a));
            }
           
        }
    }
}
