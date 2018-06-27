using Builder.Builders;
using Builder.Pub;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDrinkBuilder coffeeBuilder = new CoffeeBuilder();
            AbstractDrinkBuilder teaBuilder = new TeaBuilder();

            Waiter waiter1 = new Waiter();
            waiter1.SetBuilder(coffeeBuilder);
            waiter1.OrderDrink();

            Waiter waiter2 = new Waiter();
            waiter2.SetBuilder(teaBuilder);
            waiter2.OrderDrink();

            Drink drink1 = waiter1.GetDrink();
            Drink drink2 = waiter2.GetDrink();

            Console.WriteLine($"1st customer is drinking a {drink1.Size} {drink1.Name}.");
            Console.WriteLine($"2nd customer is drinking a {drink2.Size} {drink2.Name}.");
        }
    }
}
