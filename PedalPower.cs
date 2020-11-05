using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class PedalPower : IPowerUnit
    {
        public void ChangeRPM(int amt)
        {
            string inc = "pedalling faster";
            string dec = "pedalling slower";
            string action = (amt < 0) ? dec : inc;
            Console.WriteLine($"I'm {action}");  
        }

        public void Start()
        {
            Console.WriteLine("Started pedalling");
        }

        public void Stop()
        {
            Console.WriteLine("Resting at the bar.");
        }
    }
}
