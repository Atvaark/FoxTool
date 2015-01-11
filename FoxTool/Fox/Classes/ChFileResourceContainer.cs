using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ChFileResourceContainer : DataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public Dictionary<string, FoxFilePtr> Resources { get; set; }
    }
}
