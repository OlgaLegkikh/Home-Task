using System;
namespace Exam_Task_5
{
	public class SuperHero : Person
	{
		public string SuperPower;
		public SuperHero(string name, int age, string superPower) : base(name, age)
		{
			SuperPower = superPower;
		}

        public override void Print()
        {
            base.Print();
			Console.WriteLine($"{Name} has a SuperPower: {SuperPower}");
        }
    }
}

