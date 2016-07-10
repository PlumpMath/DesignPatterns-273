using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.FactoryPattern
{
    class WorkDocument : Document
    {
        public override void CreatePages()
        {
            base.Pages.Add(new SkillsPage());
            base.Pages.Add(new SkillsPage());
            base.Pages.Add(new SkillsPage());
            base.Pages.Add(new SkillsPage());
        }
    }
}
