using Strategy.Police;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var hardPolice = new HardPolice();
            var nicePolice = new NicePolice();

            var situationOne = new Situation(hardPolice);
            var situationTwo = new Situation(nicePolice);

            situationOne.Handle(speed: 100);
            situationTwo.Handle(speed: 100);
        }
    }
}
