using System;
namespace Magic_Task_5
{
    public class LifeWater : Spell
    {
        public LifeWater() : base()
        {
        }

        public void CastLifeWater()
        {
            Mana -= 1;
            Health += 1;
            IndicatorsChange();
        }

    }
}
