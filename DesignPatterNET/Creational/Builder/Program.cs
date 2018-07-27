using Builder.Builders;
using Builder.Pub;
using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            AbstractDrinkBuilder coffeeBuilder = new CoffeeBuilder();
            AbstractDrinkBuilder teaBuilder = new TeaBuilder();

            Waiter waiter1 = new Waiter(coffeeBuilder);
            waiter1.OrderDrink();

            Waiter waiter2 = new Waiter(teaBuilder);
            waiter2.OrderDrink();

            Drink drink1 = waiter1.OrderedDrink;
            Drink drink2 = waiter2.OrderedDrink;

            Console.WriteLine($"1st customer is drinking a {drink1.ToString()}.");
            Console.WriteLine($"2nd customer is drinking a {drink2.ToString()}.");
        }
    }
}
