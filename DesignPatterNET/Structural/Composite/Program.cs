using Composite.Components;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Leaf leaf1 = new Leaf("1");
            Leaf leaf2 = new Leaf("2");
            Leaf leaf3 = new Leaf("3");
            Leaf leaf4 = new Leaf("4");
            Leaf leaf5 = new Leaf("5");

            Tree tree1 = new Tree();
            tree1.Add(leaf1);
            tree1.Add(leaf2);

            Tree tree2 = new Tree();
            tree2.Add(leaf3);
            tree2.Add(leaf4);
            tree2.Add(leaf5);

            tree1.Add(tree2);
            tree1.Show();
        }
    }
}
