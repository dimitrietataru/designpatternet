using Interpreter.Interfaces;
using System;

namespace Interpreter.Expressions
{
    public class ExpressionB : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Expression B");

            context.Input = context.Input.Substring(0, 2);
            context.Output = $"{context.Input}{context.Output} 2";
        }
    }
}
