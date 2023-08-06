using System;
namespace Exam_task_6
{
	public class Truck
	{
		public string Name { get; set; }
		public int SerialNumber { get; set; }
		public Truck(string name, int serialNumber)
		{
			Name = name;
			SerialNumber = serialNumber;
		}
	}
}

