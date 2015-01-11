namespace FoxTool.Fox
{
    internal class FoxKeyValuePair<TKey, TValue> : IFoxKeyValuePair<TKey, TValue>
    {
        public FoxKeyValuePair()
        {
        }

        public FoxKeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
