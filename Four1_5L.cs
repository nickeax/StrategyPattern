using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Four1_5L : IPowerUnit
    {
        private String desc = "Four Cylinder 1.5";
        private int _rpm;
        public int RPM { get { return _rpm; } set { _rpm = value; } }

        private int _temperature;
        public int Temperature { set { _temperature = value; } }

        public void ChangeRPM(int amt)
        {
            RPM += amt;
            Console.WriteLine($"{desc} RPM: {RPM}");
        }

        public void Start()
        {
            Console.WriteLine($"{desc} has started.");
        }

        public void Stop()
        {
            Console.WriteLine($"{desc} has been shut down.");
        }
    }
}
