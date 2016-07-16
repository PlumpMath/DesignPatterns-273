using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.CompositePattern
{
    class File : Component
    {
        public File(string fileName) : base(fileName)
        {

        }
        public override void Add(Component c)
        {
            Console.Write("cannot add to leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(string.Format("{0} {1}", new string('-', depth), name));
        }

        public override void Remove(Component c)
        {
            Console.Write("cannot remove from leaf");
        }
    }
}
