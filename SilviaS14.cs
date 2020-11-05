using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class SilviaS14 : Vehicle
    {
        public SilviaS14()
        {
            engine = new Four1_5L();
        }

        public void Accelerate()
        {
            engine.ChangeRPM(20);
        }
    }
}
