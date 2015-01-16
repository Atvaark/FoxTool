using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppRouteSet
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxString> RouteIds { get; set; }
        public List<FoxInt32> RouteGroupIndexes { get; set; }
        public FoxUInt32 PriorRouteCount { get; set; }
    }
}
