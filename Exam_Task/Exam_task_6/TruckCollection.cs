using System;
namespace Exam_task_6
{
	public class TruckCollection : IVehicleCollection<Truck>
	{
        private List<Truck> _innerList;

        public TruckCollection()
        {
            _innerList = new List<Truck>();
        }

        public void AddVehicle(Truck item)
        {
            _innerList.Add(item);
        }

        public bool ContainsVehicle(Truck item)
        {
            bool found = false;
            foreach (Truck truck in _innerList)
            {
                if (truck.SerialNumber == item.SerialNumber)
                {
                    found = true;
                }
            }
                return found;

        }

        public void ShowVehicles()
        {
            foreach (Truck item in _innerList)
            {
                Console.WriteLine($"{item.Name} : {item.SerialNumber}");
            }
        }
    }
}

