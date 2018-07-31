using Template.Interfaces;

namespace Template.Vehicles
{
    public class Truck : AbstractVehicle
    {
        public override void Start() => Status = true;
        public override void Run() => System.Console.WriteLine("Truck is running slowly");
        public override void Stop() => System.Console.WriteLine("Truck stopped");
    }
}
