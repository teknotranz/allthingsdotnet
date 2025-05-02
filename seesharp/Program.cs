using System;

namespace Seesharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //initialize an array of nullabe persons
            var persons = new Person?[]
            {
                new Person("John", 30),
                null,
                new Person("Jane", 25)
            };


        }
    }

    class Intro
    {

        #region Coalesce
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
        #endregion

        #region NameOfExample
        public static void NameOfExample()
        {
            // The nameof operator returns the simple name of a variable, type, or member as a string.
            string testVariable = "example";
            string variableName = nameof(testVariable);
            Console.WriteLine($"The name of the variable is: {variableName}");

            // Example with a class and property
            Person person = new Person("John", 30);
            string propertyName = nameof(person.Name);
            Console.WriteLine($"The name of the property is: {propertyName}");
        }
        #endregion
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
