using Interpreter.Expressions;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        private const string Expression = "abcd";

        static void Main(string[] args)
        {
            var context = new Context(Expression);
            var expressions = new List<AbstractExpression> { new ExpressionA(), new ExpressionB() };

            expressions.ForEach(expression => expression.Interpret(context));

            Console.WriteLine($"Output: '{context.Output}'");
        }
    }
}
