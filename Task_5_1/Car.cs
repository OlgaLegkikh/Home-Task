using System;
namespace Task_5_1
{
    public class Car : Vehicle
    {
        
        public Car()
        {
        }

        public new void Move()
        {
            Console.WriteLine($"{this.Brand} едет");
        }
    }
}
