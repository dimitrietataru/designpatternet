namespace Template.Interfaces
{
    public abstract class AbstractVehicle
    {
        protected bool Status { get; set; }

        public abstract void Start();
        public abstract void Run();
        public abstract void Stop();

        public void Test()
        {
            Start();
            if (Status)
            {
                Run();
                Stop();
            }
        }
    }
}
