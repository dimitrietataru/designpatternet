using System.Collections.Generic;

namespace Flyweight.Pub
{
    public class Waitress
    {
        private readonly Machine machine;
        private List<(Coffee coffee, Table table)> orders;

        public Waitress()
        {
            machine = new Machine();
            orders = new List<(Coffee, Table)>();
        }

        public void TakeOrder(string flavor, int number)
        {
            orders.Add((machine.GetCoffee(flavor), new Table(number)));
        }

        public void ProcessOrders()
        {
            orders.ForEach(order => order.coffee.Serve(order.table));
        }
    }
}
