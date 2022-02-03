using SimulareExamenProblema3.TransformationRules;
using System;

namespace SimulareExamenProblema3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Rezolvarea problemei 3 de la simularea examenului";
            string result = StringProcessingEngine.Transform(
                text,
                // flexibly transform input string
                // by specifying different rules to follow
                new ReplaceStringTransformationRule(lookupText: "problemei", replaceWithText: "exercitiului"),
                new InsertStringTransformationRule(0, "Aici avem "),
                new LowercaseAllTransformationRule());

            Console.WriteLine(result);
        }
    }
}
