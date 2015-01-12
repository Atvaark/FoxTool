namespace FoxTool.Fox
{
    public interface IFoxKeyValuePair<out TKey, out TValue>
    {
        TKey Key { get; }
        TValue Value { get; }
    }
}
