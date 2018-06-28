using Composite.Interfaces;
using System.Collections.Generic;

namespace Composite.Components
{
    public class Tree : IComponent
    {
        private List<IComponent> childs;

        public Tree() => childs = new List<IComponent>();

        public void Add(IComponent component) => childs.Add(component);
        public void Remove(IComponent component) => childs.Remove(component);
        public void Show() => childs.ForEach(child => child.Show());
    }
}
