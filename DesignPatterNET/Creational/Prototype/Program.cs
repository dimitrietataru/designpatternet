namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = new Prototype(0);

            for (int i = 1; i < 6; ++i)
            {
                Prototype temp = prototype.Clone() as Prototype;
                temp.SetSize(i);
                temp.PrintSize();
            }

            for (int i = 11; i < 16; ++i)
            {
                Prototype temp = prototype.CloneManually();
                temp.SetSize(i);
                temp.PrintSize();
            }
        }
    }
}
