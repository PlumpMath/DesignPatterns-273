using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Prototype
{
    public abstract class Prototype
    {
        int _id = 0;
        public Prototype(int id)
        {
            _id = id;
        }
        public abstract Prototype Clone();
        public int Id { get; set; }
    }
}
