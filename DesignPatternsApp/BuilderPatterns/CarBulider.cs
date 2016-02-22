using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BuilderPatterns
{
    public abstract class CarBulider
    {

       public CarBulider()
        {
            BuildCar();
        }

        protected Car car;
        public  Car GetCar()
        {
            return this.car;
        }
        public void BuildCar()
        {
            this.car = new Car();
        }

        public abstract void  addWeels();
        public abstract void paintColor();

        public abstract void setType();

    }
}
