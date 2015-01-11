using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DataIdentifier
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString Identifier { get; set; }
        public Dictionary<string, FoxEntityLink> Links { get; set; }
    }
}
