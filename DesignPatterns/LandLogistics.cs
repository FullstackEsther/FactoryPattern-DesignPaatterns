using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class LandLogistics : Logistics
    {
        public override IMedium Create()
        {
            return new Truck();
        }
    }
}
