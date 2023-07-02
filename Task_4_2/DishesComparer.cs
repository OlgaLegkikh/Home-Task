using System;
using System.Collections.Generic;

namespace Task_4_2
{
    public class DishesComparer : IComparer<Dish>
    {

        public int Compare(Dish x, Dish y)
        {
            if(x.Price < y.Price)
                return -1;
            if (x.Price > y.Price)
                return 1;
            if(x.Mass < y.Mass)
                return -1;
            if (x.Mass > y.Mass)
                return 1;
            else return 0;
        }
    }
}
