using System;
namespace Exam_Task_5
{
	public class Person
	{
		public string Name;
		public int Age;
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

        public virtual void Print()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }
}

