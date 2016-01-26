using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä26._1._2016
{
    class Vehicle : Tyres
    {

        public string Name { get; set; }
        public string Model { get; set; }
        
        
        public List<Tyres> Tyres { get; }

        public Vehicle()
        {
            
            Tyres = new List<Tyres>();
      
        }
        public void AddTyre(Tyres tyre)
        {
            Tyres.Add(tyre);
        }
        public override string ToString()
        {
           

            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + "Engine : " +" Tyres: \n";
            foreach (Tyres tyre in Tyres)foreach (Engine engine in Engine)

            {
                sVehicle += tyre.ToString() + "\n";
            }
        }
    }
    }
