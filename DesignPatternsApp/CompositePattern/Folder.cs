using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.CompositePattern
{
    class Folder : Component
    {
        private List<Component> _children = new List<Component>();
        public Folder(string folderName): base(folderName)
        {

        }
        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            _children.Add(c);
        }
    }
}
