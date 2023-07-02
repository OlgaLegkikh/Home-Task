using System;
namespace Task_5_1
{
    public class Person
    {
        public string Name;
        private Vehicle vehicle;
        public Person(string name)
        {
            Name = name;
        }

        public void PersonMove()
        {
            if (vehicle == null)
            {
                Console.WriteLine($"{Name} на своих двоих");
            }
            else
            {
                Console.WriteLine($"{Name} на {vehicle.Brand}");
            }

        }

        public void ChangeVehicle(Vehicle newVehicle)
        {
            this.vehicle = newVehicle;
        }
    }
}
