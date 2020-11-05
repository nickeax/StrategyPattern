namespace strategy
{
    public class Vehicle
    {
        public int Speed { get; set; }

        private int _wheels;
        public int Wheels { get { return _wheels; } set { _wheels = value; }}
        
        public IPowerUnit engine;

        public void ChangeEngine(IPowerUnit eng)
        {
            engine = eng;
        }

        public void Accelerate(int amt)
        {
            engine.ChangeRPM(amt);
        }
    }
}