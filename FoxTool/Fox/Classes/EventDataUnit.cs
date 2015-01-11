using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class EventDataUnit
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString EventName { get; set; }
        public FoxEntityPtr Sections { get; set; }
        public List<FoxString> ParamString { get; set; }
        public List<FoxInt32> ParamInt { get; set; }
        public FoxFloat ParamFloat { get; set; }
    }
}
