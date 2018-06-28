using System;

namespace Builder.Builders
{
    public class TeaBuilder : AbstractDrinkBuilder
    {
        public override void BuildDrink()
        {
            Drink.Name = "tea";
            Console.WriteLine("Building a tea");
        }

        public override void BuildSize()
        {
            Drink.Size = "large";
            Console.WriteLine("Building a large drink" + Environment.NewLine);
        }
    }
}
