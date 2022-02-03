using System;

namespace SimulareExamenProblema3.TransformationRules
{
    public class ReplaceStringTransformationRule : TransformationRule
    {
        public ReplaceStringTransformationRule(
            string lookupText,
            string replaceWithText)
        {
            LookupText = lookupText ?? string.Empty;
            ReplaceWithText = replaceWithText ?? string.Empty;
        }

        public string LookupText { get; }

        public string ReplaceWithText { get; }

        public override string Transform(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value.Replace(LookupText, ReplaceWithText, StringComparison.CurrentCulture);
            }

            // if value is null or empty, simply return it back
            return value;
        }
    }
}
