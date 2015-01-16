using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppEventSequenceManagerData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath ScriptPath { get; set; }
        public FoxInt32 StartCondition { get; set; }
        public Dictionary<string, FoxEntityLink> DataFromEntityLink { get; set; }
        public Dictionary<string, FoxEntityLink> ProceduralDemoManagers { get; set; }
    }
}
