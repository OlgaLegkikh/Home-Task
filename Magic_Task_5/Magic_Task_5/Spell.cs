using System;
namespace Magic_Task_5
{
    public class Spell : Magic
    {
        public Spell() : base()
        {
        }

        protected override void IndicatorsChange()
        {
            Console.WriteLine("You cast the spell!");
            UserIndicators();

        }
    }
}
