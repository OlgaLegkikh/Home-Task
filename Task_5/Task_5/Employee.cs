using System;
namespace Task_5
{
    public class Employee : Person
    {
        protected string EmployeeFirstName { get; set; }
        protected string EmployeeSecondName { get; set; }


        public Employee(string firstName, string secondName)
        {
            EmployeeFirstName = firstName;
            EmployeeSecondName = secondName;
        }

        public override void SolveProblem()
        {
            Console.WriteLine($"Проблема решана, спасибо {EmployeeFirstName}");
        }
    }
}
