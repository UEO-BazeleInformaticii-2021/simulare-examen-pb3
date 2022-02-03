namespace SimulareExamenProblema3.TransformationRules
{
    public class InsertStringTransformationRule : TransformationRule
    {
        public InsertStringTransformationRule(
            int index,
            string text)
        {
            Index = index;
            Text = text ?? string.Empty;
        }

        public int Index { get; }

        public string Text { get; }

        public override string Transform(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (Index >= 0 && Index < value.Length)
                {
                    // index is correct
                    return value.Insert(Index, Text);
                }
                else
                {
                    // index is not correct, append at the end
                    return value + Text;
                }
            }

            // if value is null or empty, simply return it back
            return value;
        }
    }
}
