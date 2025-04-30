using System;

namespace Seesharp
{    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class Intro
    {
        string test = "test";
        //coalesce operator
        // The null-coalescing operator ?? returns the left-hand operand
        //if it is not null; otherwise, it returns the right operand.
        // the equivalent expression using the conditional operator is: 
        // name != null ? name : "default"
        public void Coalesce()
        {
            string? name = null;
            string name2 = name ?? "default";
            Console.WriteLine(name2);
        }

        public void nameof()
        {
            // The nameof operator returns the name of a variable, type, or member as a string.
            // It is useful for avoiding hard-coded strings in your code.
            string name = nameof(name);
            Console.WriteLine(name);
        }
    }
}
