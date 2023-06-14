using System;
namespace Magic_Task_5
{
    public abstract class Magic

    {
     protected int Health = 10;
     protected int Mana = 10;
     protected int Damage = 5;

    protected Magic()
        {

        }

    protected abstract void IndicatorsChange();

    public void UserIndicators()
        {
            Console.WriteLine($"Your health is: {Health}");
            Console.WriteLine($"Your mana is: {Mana}");
            Console.WriteLine($"Damage by your sword is: {Damage}");
        }

    }
}
