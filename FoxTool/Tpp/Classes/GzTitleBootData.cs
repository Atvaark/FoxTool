using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class GzTitleBootData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr UigFiles { get; set; }
        public List<FoxFilePtr> RawFiles { get; set; }
    }
}
