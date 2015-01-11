namespace FoxTool.Fox
{
    public class FoxEnumValue
    {
        public FoxEnumValue(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }
        // TODO: Check if there are non int32 enums.
        public int Value { get; private set; }
    }
}