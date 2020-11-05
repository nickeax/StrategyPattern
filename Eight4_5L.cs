using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Eight4_5L : IPowerUnit
    {
        private int _rpm;

        public int RPM
        {
            get { return _rpm; }
            set { _rpm = value; }
        }

        private String desc = "Eight Cylinder 4.5l";
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
