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


            // Convert this readonly property to an expression member
            public string FormalName
            {
                 
                {
                    return $"{this.Name} the {this.Species}";
                }
            }

            // Class constructor
            public Bug(string name, string species, List<string> predators, List<string> prey)
            {
                this.Name = name;
                this.Species = species;
                this.Predators = predators;
                this.Prey = prey;
            }

            // Convert this method to an expression member
            public string PreyList()
            {
                var commaDelimitedPrey = string.Join(",", this.Prey);
                return commaDelimitedPrey;
            }

            // Convert this method to an expression member
            public string PredatorList()
            {
                var commaDelimitedPredators = string.Join(",", this.Predators);
                return commaDelimitedPredators;
            }

            // Convert this to expression method
            public string Eat(string food)
            {
                if (this.Prey.Contains(food))
                {
                    return $"{this.Name} ate the {food}.";
                }
                else
                {
                    return $"{this.Name} is still hungry.";
                }
            }
        }
    }
    }
}
