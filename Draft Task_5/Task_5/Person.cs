using System;
namespace Task_5
{
    public abstract class Person
    {
        protected string FirstName;
        protected string LastName;
        protected int YearOfBirth;

        public Person()
        {
        }

        public virtual void NewPerson(string firstName, string lastName, int yearOfBirth)
        {
            Console.WriteLine($"{firstName} {lastName} теперь с нами!");
            Console.WriteLine($"Возраст {firstName} {lastName} равен {personAge(yearOfBirth)} годам(у)");
        }

        public abstract void SolveProblem();

        protected int personAge(int YearOfBirth)
        {
            int age = DateTime.Now.Year - YearOfBirth;
            return age;
        }
        
    }
}
