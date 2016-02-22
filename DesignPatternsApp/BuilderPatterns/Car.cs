using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.BuilderPatterns
{
    public class Car
    {
        public string Color { get; set; }

        public string TypeOfCar { get; set; }
        public int NumOfWeels { get; set; }
        public  void PrintCar()
        {
            Console.WriteLine(string.Format("{0}: color: {1}: wheels {2}", this.TypeOfCar, this.Color, this.NumOfWeels));
        }
    }
}
