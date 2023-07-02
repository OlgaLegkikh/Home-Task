using System;
namespace Task_5_1
{
    public class Boat : Vehicle
    {
        public new string Brand = "Англер";
        public Boat()
        {
        }


        public new void Move()
        {
            Console.WriteLine($"{this.Brand} плывет");
        }

    }
}
