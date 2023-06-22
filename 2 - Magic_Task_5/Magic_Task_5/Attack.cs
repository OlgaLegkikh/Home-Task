using System;
namespace Magic_Task_5
{
    public class Attack : Magic
    {
        public Attack() : base()
        {
        }

        protected override void IndicatorsChange()
        {
            Console.WriteLine("You attacked an enemy!");
            UserIndicators();

        }

        public void UserAttack()
        {
            Random rnd = new Random();
            Health = Health - rnd.Next(0, 6);
            Damage = Damage + rnd.Next(-4, 5);
            IndicatorsChange();
        }
    }
}
