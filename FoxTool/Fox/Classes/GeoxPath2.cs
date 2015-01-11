using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoxPath2
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public List<FoxEntityPtr> Nodes { get; set; }
        public List<FoxEntityPtr> Edges { get; set; }
        public FoxInt32 SelectIndex { get; set; }
        public FoxBool Enable { get; set; }
        public FoxString Tags { get; set; }
    }
}
