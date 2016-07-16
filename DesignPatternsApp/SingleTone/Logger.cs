using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.SingleTone
{
    public class Logger
    {
        private static Logger _instance;
        protected Logger()
        {

        }
        // Uses lazy initialization.      
        // Note: this is not thread safe.      

        public static Logger Instance()
        {

            if (_instance == null)
            {
                _instance = new Logger();

            }
            return _instance;

        }

    }
}
