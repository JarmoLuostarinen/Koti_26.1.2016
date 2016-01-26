using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä26._1._2016
{
    interface IEngine
    {
       string Name { get; set; }
       string Type { get; set; }
       string Size { get; set; }

        string Stuff();
       
    }
}
