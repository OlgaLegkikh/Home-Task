using System;
namespace Exam_task_6
{
	public interface IVehicleCollection<T> 
	{
		void AddVehicle(T item);
        bool ContainsVehicle(T item);
		void ShowVehicles();

	}
}

