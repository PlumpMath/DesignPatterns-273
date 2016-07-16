using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.ChainOfResponsibility
{
    class ConcreteHandler1 : Handler
    {
        public override void handleRequest(int a)
        {
           if(a>=0  && a<=10)
            {
                Console.Write(string.Format("ConcreteHandler1 handleRequest {0}", a));
            }
           else if (successor != null)
            {
                successor.handleRequest(a);
            }
        }
    }
}
