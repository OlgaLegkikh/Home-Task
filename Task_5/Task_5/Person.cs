using System;
namespace Task_5
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected int yearOfBirth;
        

        public virtual void NewPerson(string firstName, string lastName, int yearOfBirth)
        {
            Console.WriteLine($"{firstName} {lastName} теперь с нами!");
            Console.WriteLine($"Возраст {firstName} {lastName} равен {personAge(yearOfBirth)} годам(у)");
        }

        public abstract void SolveProblem();

        protected int personAge(int yearOfBirth)
        {
            int age = DateTime.Now.Year - yearOfBirth;
            return age;
        }
        
    }
}
