namespace SimulareExamenProblema3.TransformationRules
{
    public class LowercaseAllTransformationRule : TransformationRule
    {
        public override string Transform(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value.ToLower();
            }

            // if value is null or empty, simply return it back
            return value;
        }
    }
}
