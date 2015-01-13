using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppCombatLocatorSetData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat Radius { get; set; }
        public FoxFloat LostSearchRadius { get; set; }
        public List<FoxEntityLink> Locators { get; set; }
    }
}
