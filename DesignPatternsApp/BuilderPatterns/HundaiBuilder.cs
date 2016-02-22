using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BuilderPatterns
{
    public class HundaiBuilder : CarBulider
    {
        public override void addWeels()
        {
            this.car.NumOfWeels = 4 * 2;
        }

        public override void paintColor()
        {
            this.car.Color = "blue";
        }
        public override void setType()
        {
            this.car.TypeOfCar = "Hundai";
        }

    }
}
