using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Bicycle : Vehicle
    {
        public Bicycle()
        {
            engine = new PedalPower();
        }
    }
}
