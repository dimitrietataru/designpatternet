namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype p = new Prototype(1);

            for (int i = 2; i < 10; ++i)
            {
                Prototype temp = p.Clone() as Prototype;
                temp.SetSize(i);
                temp.PrintSize();
            }
        }
    }
}
