using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsApp.BridgePattern;
using DesignPatternsApp.BuilderPatterns;

namespace DesignPatternsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //callBridgePattern();
            callBuilderPattern();

        }

        private static void callBuilderPattern()
        {

            CarMaker carMaker = new CarMaker(new FordBuilder());
            carMaker.BuildCar();
            var car1 = carMaker.GetCar();
            car1.PrintCar();

            CarMaker carMaker2 = new CarMaker(new HundaiBuilder());
            carMaker2.BuildCar();
            var car2 = carMaker2.GetCar();
            car2.PrintCar();
        }

        private static void callBridgePattern()
        {
            EnglishFormat e = new EnglishFormat();
            EnglishMenu em = new EnglishMenu(e);
            FranchFormatter ff = new FranchFormatter();
            FrenchMenu fm = new FrenchMenu(ff);

            List<Menuscript> menues = new List<Menuscript>();
            menues.Add(em);
            menues.Add(fm);
            menues.ForEach(x => Console.WriteLine(x.Print("e", "k")));
            
        }
    }
}
