using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppGimmickPartsInstanceData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr PartsFile { get; set; }
        public FoxUInt32 Size { get; set; }
    }
}
