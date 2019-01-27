using Template.Interfaces;

namespace Template.Vehicles
{
    public class Car : AbstractVehicle
    {
        public override void Start() => status = true;

        public override void Run() => System.Console.WriteLine("Car is running fast");

        public override void Stop() => System.Console.WriteLine("Car stopped");
    }
}
