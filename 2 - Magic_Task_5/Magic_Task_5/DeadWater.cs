using System;
namespace Magic_Task_5
{
    public class DeadWater : Spell
    {
        public DeadWater() : base()
        {
        }

        public void CastDeadWater()
        {
            Mana += 2;
            Health -= 1;
            IndicatorsChange();
        }
    }
}
