using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BuilderPatterns
{
    public class CarMaker
    {
        private readonly CarBulider builder;
        public CarMaker(CarBulider o_bulider)
        {
            this.builder = o_bulider;
        }

        /// <summary>
        /// set the orde and logic of creaing the object
        /// </summary>
        public void BuildCar()
        {
            builder.addWeels();
            builder.paintColor();
            builder.setType();

        }
        public Car GetCar()
        {
            return builder.GetCar();
        }
    }
}
