using VehicleManagementSystem.Interfaces;

namespace VehicleManagementSystem
{
    abstract class VehicleFactory
    {
        // abstract method for creating vehicle
        public abstract IVehicle CreateVehicle();

        public void DoSomethingWithVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            Console.WriteLine("Doing something with the vehicle");
            // call the drive method on the basis of created vehicle
            vehicle.Drive();
        }
    }

    class CarFactory : VehicleFactory
    {
        // override the Vehiclefactory Method and create a Car instance
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }

    class TruckFactory : VehicleFactory
    {
        // override the Vehiclefactory Method and create a Truck instance
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}
