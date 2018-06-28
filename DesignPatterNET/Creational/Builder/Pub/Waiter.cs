using Builder.Builders;

namespace Builder.Pub
{
    public class Waiter
    {
        private AbstractDrinkBuilder drinkBuilder;

        public void SetBuilder(AbstractDrinkBuilder drinkBuilder) => this.drinkBuilder = drinkBuilder;

        public Drink GetDrink() => drinkBuilder.Drink;

        public void OrderDrink()
        {
            drinkBuilder.OrderDrink();
            drinkBuilder.BuildDrink();
            drinkBuilder.BuildSize();
        }
    }
}
