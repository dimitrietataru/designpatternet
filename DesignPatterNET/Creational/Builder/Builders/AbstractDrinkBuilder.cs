using Builder.Pub;

namespace Builder.Builders
{
    public abstract class AbstractDrinkBuilder
    {
        protected Drink drink;

        public void OrderDrink()
        {
            drink = new Drink();
            System.Console.WriteLine("A new order was created");
        }

        public Drink GetDrink() => drink;

        public abstract void BuildDrink();
        public abstract void BuildSize();
    }
}
