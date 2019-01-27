namespace Template.Interfaces
{
    public abstract class AbstractVehicle
    {
        protected bool status;

        public abstract void Start();
        public abstract void Run();
        public abstract void Stop();

        public void Test()
        {
            Start();
            if (status)
            {
                Run();
                Stop();
            }
        }
    }
}
