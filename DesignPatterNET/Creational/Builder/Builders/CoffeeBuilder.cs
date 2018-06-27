using System;

namespace Builder.Builders
{
    public class CoffeeBuilder : AbstractDrinkBuilder
    {
        public override void BuildDrink()
        {
            drink.Name = "coffee";
            Console.WriteLine("Building a coffee");
        }

        public override void BuildSize()
        {
            drink.Size = "small";
            Console.WriteLine("Building a small drink" + Environment.NewLine);
        }
    }
}
