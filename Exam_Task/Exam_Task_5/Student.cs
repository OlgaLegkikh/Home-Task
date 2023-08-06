using System;
namespace Exam_Task_5
{
	public class Student : Person
	{
		public string University;
		public Student(string name, int age,string university) : base(name, age)
		{
			University = university;
		}

        public override void Print()
        {
			base.Print();
			Console.WriteLine($"{Name} study at {University}");
        }
    }
}

