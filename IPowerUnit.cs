namespace strategy
{
    public interface IPowerUnit
    {
        void Start();
        void Stop();
        void ChangeRPM(int amt);
    }
}