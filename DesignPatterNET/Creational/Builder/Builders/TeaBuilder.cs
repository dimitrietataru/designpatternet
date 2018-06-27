using System;

namespace Builder.Builders
{
    public class TeaBuilder : AbstractDrinkBuilder
    {
        public override void BuildDrink()
        {
            drink.Name = "tea";
            Console.WriteLine("Building a tea");
        }

        public override void BuildSize()
        {
            drink.Size = "large";
            Console.WriteLine("Building a large size drink" + Environment.NewLine);
        }
    }
}
