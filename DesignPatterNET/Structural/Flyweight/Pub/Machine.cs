using System.Collections.Generic;

namespace Flyweight.Pub
{
    public class Machine
    {
        private Dictionary<string, Coffee> flavors;

        public Machine() => flavors = new Dictionary<string, Coffee>();

        public Coffee GetCoffee(string flavor)
        {
            flavors.TryGetValue(flavor, out Coffee coffee);

            if (coffee == null)
            {
                coffee = new Coffee(flavor);
                flavors[flavor] = coffee;
            }

            return coffee;
        }

        public int GetTotalCoffees() => flavors.Count;
    }
}
