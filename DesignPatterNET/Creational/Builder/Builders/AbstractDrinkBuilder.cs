using Builder.Pub;
using System;

namespace Builder.Builders
{
    public abstract class AbstractDrinkBuilder
    {
        public Drink Drink { get; private set; }

        public void OrderDrink()
        {
            Drink = new Drink();
            Console.WriteLine("A new order was created");
        }

        public abstract void BuildDrink();
        public abstract void BuildSize();
    }
}
