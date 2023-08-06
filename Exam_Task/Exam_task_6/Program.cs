// See https://aka.ms/new-console-template for more information
using Exam_task_6;

Vehicle car = new Vehicle("Малиновая лада");
Vehicle bicycle = new Vehicle("Велик");
Vehicle tractor = new Vehicle("Синий трактор");

var Garage = new VehicleCollection();

Garage.AddVehicle(car);
Garage.AddVehicle(bicycle);
if (Garage.ContainsVehicle(bicycle))
{
    Garage.AddVehicle(tractor);
}
else
{
    Garage.AddVehicle(bicycle);
}

Garage.ShowVehicles();

Console.WriteLine(Environment.NewLine);
Truck Tom = new Truck("Том", 23);
Truck Bethy = new Truck("Бетти", 23);
Truck John = new Truck("Джон", 5);

var TruckGarage = new TruckCollection();
TruckGarage.AddVehicle(Tom);
if (TruckGarage.ContainsVehicle(Bethy))
{
    TruckGarage.AddVehicle(John);
}
else
{
    TruckGarage.AddVehicle(Bethy);
}
TruckGarage.ShowVehicles();
