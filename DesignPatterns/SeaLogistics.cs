using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SeaLogistics : Logistics
    {
        public override IMedium Create()
        {
            return new Ship();
        }
    }
}
