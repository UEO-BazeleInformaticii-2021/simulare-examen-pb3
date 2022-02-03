using SimulareExamenProblema3.TransformationRules;

namespace SimulareExamenProblema3
{
    public static class StringProcessingEngine
    {
        public static string Transform(
            string value,
            params TransformationRule[] rules)
        {
            foreach (TransformationRule rule in rules ?? new TransformationRule[0])
            {
                value = rule.Transform(value);
            }

            return value;
        }
    }
}
