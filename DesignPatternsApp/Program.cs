using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsApp.BridgePattern;
using DesignPatternsApp.BuilderPatterns;
using DesignPatternsApp.Adapter_Pattern;
using DesignPatternsApp.FacadePattern;
using DesignPatternsApp.ChainOfResponsibility;
using DesignPatternsApp.ObserverPattern;
using DesignPatternsApp.MediatorPattern;

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

        private static void callAdapterPattern()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }

        private static void callFacade()
        {
            Facade facade = new Facade();

            facade.procedureOne();
            facade.procedureTwo();

            // Wait for user
            Console.ReadKey();
        }

        private static void callChainOfResponsibility()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.handleRequest(request);
            }

            // Wait for user
            Console.ReadKey();
        }

        private static void callObserver()
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            // Wait for user
            Console.ReadKey();
        }

        private static void callMediator()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            // Wait for user
            Console.ReadKey();
        }
         
    }
}
