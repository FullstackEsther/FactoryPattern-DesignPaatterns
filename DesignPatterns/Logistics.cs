using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Logistics
    {
        public abstract IMedium Create();
        public void DeliverGood(string good)
        {
            Create().Deliver(good);
        }
    }
}
