using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ClothDescription
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink Depends { get; set; }
        public FoxString PartName { get; set; }
        public FoxString BuildType { get; set; }
        public FoxFilePtr ClothFile { get; set; }
        public FoxFilePtr ClothSettingFile { get; set; }
    }
}
