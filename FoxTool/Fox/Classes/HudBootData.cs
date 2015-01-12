using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class HudBootData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr UigFiles { get; set; }
        public List<FoxFilePtr> RawFiles { get; set; }
    }
}
