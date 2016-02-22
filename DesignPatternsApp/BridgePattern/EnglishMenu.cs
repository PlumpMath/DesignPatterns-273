using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BridgePattern
{
    public class EnglishMenu : Menuscript
    {
        public EnglishMenu(IFormater formatter) : base(formatter)
        { }

        public override string Print(string key, string value)
        {
            return formatter.Format(key, value);
        }
    }
}
