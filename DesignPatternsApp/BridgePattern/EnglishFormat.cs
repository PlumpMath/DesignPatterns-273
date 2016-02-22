using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BridgePattern
{
    public class EnglishFormat : IFormater
    {
        public string Format(string key, string value)
        {
            return (key + key + key + value);
        }
    }
}
