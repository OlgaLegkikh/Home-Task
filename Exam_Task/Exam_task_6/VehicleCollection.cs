using System;
namespace Exam_task_6
{
	public class VehicleCollection : IVehicleCollection<Vehicle> 
	{
        private List<Vehicle> _innerList;

        public VehicleCollection()
		{
            _innerList = new List<Vehicle>();
		}


        public void AddVehicle(Vehicle item)
        {
            _innerList.Add(item);
            
        }

        public bool ContainsVehicle(Vehicle item)
        {
            bool found = false;

            foreach (Vehicle vehicle in _innerList)
            {
                if (vehicle.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void ShowVehicles()
        {
            foreach (Vehicle item in _innerList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}

