using System;

namespace HomeWork2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            if (name == String.Empty)
                name = "No name";
            Console.WriteLine(Concatenationlib.Concatenate(name));
        }
    }
}