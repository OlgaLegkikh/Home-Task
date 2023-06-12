using System;
namespace Task_5
{
    public class Employee : Person
    {
        protected string EmployeeFirstName { get; set; }
        protected string EmployeeSecondName { get; set; }
        protected int YearOfBirth { get; set; }


        public Employee(string firstName, string secondName, int yearOfBirth)
        {
            EmployeeFirstName = firstName;
            EmployeeSecondName = secondName;
            YearOfBirth = yearOfBirth;
        }

        public override void NewPerson(string firstName, string lastName, int yearOfBirth)
        {
            base.NewPerson(firstName, lastName, yearOfBirth);
        }

        public override void SolveProblem()
        {
            Console.WriteLine($"Проблема решана, спасибо {EmployeeFirstName}");
        }
    }
}
