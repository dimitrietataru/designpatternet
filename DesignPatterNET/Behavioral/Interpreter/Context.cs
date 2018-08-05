namespace Interpreter
{
    public class Context
    {
        public string Input { get; set; }
        public string Output { get; set; } = "";

        public Context(string input) => Input = input;
    }
}
