using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BridgePattern
{
    public abstract class Menuscript 
    {
        protected IFormater formatter {  get; private set; }
       
        public Menuscript(IFormater formatter)
        {
            this.formatter = formatter;
        }
        public abstract string Print(string key, string value);
        
    }
}