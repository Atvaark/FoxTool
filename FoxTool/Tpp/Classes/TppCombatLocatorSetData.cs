using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
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
