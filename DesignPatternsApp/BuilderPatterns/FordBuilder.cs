using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BuilderPatterns
{

    /// <summary>
    ///no more logic , just data 
    ///The builder controlling the process
    /// </summary>
    class FordBuilder : CarBulider
    {
        public override void addWeels()
        {
            this.car.NumOfWeels = 4;
        }

        public override void paintColor()
        {
            this.car.Color = "red";
        }

        public override void setType()
        {
            this.car.TypeOfCar = "Ford";
        }
    }
}
