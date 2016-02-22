using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralModels
{
    public class ServiceResponse<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }
    }
}
