using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Truck : IMedium
    {
        public void Deliver(string good)
        {
            Console.WriteLine($"Truck: Deliver Good - {good}");
        }
    }
}
