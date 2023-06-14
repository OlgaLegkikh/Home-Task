using System;
namespace Magic_Task_5
{
    public class WhiteFire : Spell
    {
        public WhiteFire() :base()
        {
        }

        public void CastWhiteFire()
        {
            Mana -= 1;
            Damage += 1;
            IndicatorsChange();
        }
    }
}
