using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var catPredators = new List<string>()
            {
                "tiger",
                "lion",
                "panther"
            };

            var catPrey = new List<string>();
            catPrey.Add("mouse");

            var cat = new Bug("house cat", "feline", catPredators, catPrey);

            Console.WriteLine(cat.Eat("kibble"));
            Console.ReadKey();
        }
    }
}
