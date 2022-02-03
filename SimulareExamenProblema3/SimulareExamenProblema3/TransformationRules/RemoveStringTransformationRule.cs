using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulareExamenProblema3.TransformationRules
{
    public class RemoveStringTransformationRule : TransformationRule
    {
        public RemoveStringTransformationRule(
            string lookupText)
        {
            LookupText = lookupText ?? string.Empty;
        }

        public string LookupText { get; }

        public override string Transform(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                // for simplicity, remove will simply replace with empty string
                return value.Replace(LookupText, string.Empty, StringComparison.CurrentCulture);
            }

            // if value is null or empty, simply return it back
            return value;
        }
    }
}
