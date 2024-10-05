using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AirLogistics : Logistics
    {
        public override IMedium Create()
        {
            return new Airplane();
        }
    }
}
