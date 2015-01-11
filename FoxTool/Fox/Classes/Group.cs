using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class Group
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink ParentGroup { get; set; }
        public List<FoxEntityLink> Members { get; set; }
        public FoxBool DeleteFromPackage { get; set; }
    }
}
