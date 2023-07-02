using System;
namespace Task_5_1
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public Vehicle()
        {
        }

        public int Speed;

        public void Move()
        {
            Console.WriteLine($"{Brand} движется каким-то чудом");
        }
    }
}
