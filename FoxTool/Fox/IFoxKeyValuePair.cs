namespace FoxTool.Fox
{
    internal interface IFoxKeyValuePair<out TKey, out TValue>
    {
        TKey Key { get; }
        TValue Value { get; }
    }
}
