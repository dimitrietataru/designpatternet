using Flyweight.Pub;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress();

            waitress.TakeOrder("Cappuccino", 1);
            waitress.TakeOrder("Espresso", 1);
            waitress.TakeOrder("Coffee", 2);
            waitress.TakeOrder("Cappuccino", 2);
            waitress.TakeOrder("Espresso", 3);
            waitress.TakeOrder("Coffee", 4);
            waitress.TakeOrder("Cappuccino", 3);
            waitress.TakeOrder("Espresso", 5);
            waitress.TakeOrder("Coffee", 6);
            waitress.TakeOrder("Cappuccino", 4);
            waitress.TakeOrder("Espresso", 7);
            waitress.TakeOrder("Coffee", 8);

            waitress.ProcessOrders();
        }
    }
}
