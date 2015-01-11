using System.Collections.Generic;

namespace FoxTool.Fox
{
    internal interface IFoxStringMap<out T> : IFoxContainer, IEnumerable<IFoxKeyValuePair<FoxName, T>>
        where T : IFoxValue
    {
    }
}
