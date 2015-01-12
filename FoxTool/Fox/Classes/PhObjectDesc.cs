using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class PhObjectDesc
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxEntityPtr> Bodies { get; set; }
        public List<FoxEntityPtr> Constraints { get; set; }
        public List<FoxInt32> BodyIndices { get; set; }
    }
}
