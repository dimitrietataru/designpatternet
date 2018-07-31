using Template.Interfaces;
using Template.Vehicles;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();

            TestVehicle(car);
            TestVehicle(truck);
        }

        private static void TestVehicle(AbstractVehicle vehicle) => vehicle.Test();
    }
}
