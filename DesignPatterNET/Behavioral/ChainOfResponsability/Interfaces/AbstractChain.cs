namespace ChainOfResponsability.Interfaces
{
    public abstract class AbstractChain
    {
        public static int One => 1;
        public static int Two => 2;
        public static int Three => 3;
        public int Threshold { get; protected set; }
        private AbstractChain Next { get; set; }

        public void SetNext(AbstractChain chain) => Next = chain;

        public void Message(string message, int priority)
        {
            if (priority <= Threshold)
            {
                WriteMessage(message);
            }

            if (Next != null)
            {
                Next.Message(message, priority);
            }
        }

        abstract protected void WriteMessage(string message);
    }
}
