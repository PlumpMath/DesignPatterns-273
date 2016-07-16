using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public override void handleRequest(int a)
        {
           if(a>=11 && a<=20)
            {
                Console.Write(string.Format("Concretehandler2 handleRequest {0}", a));
            }
           else if(successor!=null)
            {
                successor.handleRequest(a);
            }
        }
    }
}
