using Builder.Builders;

namespace Builder.Pub
{
    public class Waiter
    {
        private protected AbstractDrinkBuilder drinkBuilder;
        public Drink OrderedDrink => drinkBuilder.Drink;

        public Waiter(AbstractDrinkBuilder drinkBuilder) => this.drinkBuilder = drinkBuilder;
        
        public void OrderDrink()
        {
            drinkBuilder.OrderDrink();
            drinkBuilder.BuildDrink();
            drinkBuilder.BuildSize();
        }
    }
}
