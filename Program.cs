using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bulding a Silvia with a Four Cylinder 1.5l engine.");

            Vehicle silvia = new SilviaS14();
            silvia.engine.Start();
            silvia.Accelerate(40);
            silvia.engine.Stop();
            
            
            silvia.ChangeEngine(new Eight4_5L());
            silvia.engine.Start();
            silvia.Accelerate(40);
            silvia.engine.Stop();

            Vehicle pushBike = new Bicycle();
            pushBike.engine.Start();
            pushBike.Accelerate(40);
            pushBike.engine.Stop();
        }
    }
}
