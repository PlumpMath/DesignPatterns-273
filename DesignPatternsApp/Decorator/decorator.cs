using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Decorator
{
    class Decorator : Component
    {
        private Component instanceOfComponenet;

        

        public void SetComponent(Component component)
        {
            this.instanceOfComponenet = component;
        }
        public override void Operation()
        {
            if(instanceOfComponenet!=null)
            {
                instanceOfComponenet.Operation();
            }
        }
    }
}
