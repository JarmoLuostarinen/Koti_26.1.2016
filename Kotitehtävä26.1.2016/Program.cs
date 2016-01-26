using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä26._1._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyres tyre1 = new Tyres { Name = "Nokia", Type = "Nasta", Size = "185R14" };
            Tyres tyre2 = new Tyres { Name = "GoodYear", Type = "Summer", Size = "225R17" };
            Tyres tyre3 = new Tyres { Name = "YokoHama", Type = "Kitka", Size = "185R13" };

            Engine engine1 = new Engine { Name = "Nissan", Type = "Bensiin", Size = "1.5L" };



            Vehicle car1 = new Vehicle { Name = "Datsun", Model = "100A" };

            car1.AddEngine(engine1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre3);
            car1.AddTyre(tyre3);

            Console.WriteLine(car1.ToString());
            Console.WriteLine("Press erter");
            Console.ReadLine();
        }
    }
}
