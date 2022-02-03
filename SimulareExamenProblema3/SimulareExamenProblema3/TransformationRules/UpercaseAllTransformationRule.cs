namespace SimulareExamenProblema3.TransformationRules
{
    public class UpercaseAllTransformationRule : TransformationRule
    {
        public override string Transform(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return value.ToUpper();
            }

            // if value is null or empty, simply return it back
            return value;
        }
    }
}
