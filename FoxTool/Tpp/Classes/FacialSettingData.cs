using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class FacialSettingData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxEntityPtr> AspectMaskList { get; set; }
        public FoxEntityPtr MouthMask { get; set; }
        public FoxEntityPtr LipMask { get; set; }
        public FoxString RootName { get; set; }
    }
}
