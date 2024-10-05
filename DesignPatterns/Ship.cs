using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Ship : IMedium
    {
        public void Deliver(string good)
        {
            Console.WriteLine($"SHip: Deliver Good - {good}");
        }
    }
}
