using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä26._1._2016
{
    class Tyres
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {



            return "Name" + Name + " Type" + Type + "Size" + Size;
        }
    }
}
