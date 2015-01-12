using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ObjectBrushPluginClone
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString ParentDataName { get; set; }
        public FoxBool Visibility { get; set; }
        public FoxFilePtr ModelFile { get; set; }
        public FoxFloat MinSize { get; set; }
        public FoxFloat MaxSize { get; set; }
        public FoxFloat FarLodSize { get; set; }
        public FoxFloat MiddleLodSize { get; set; }
        public FoxFloat NearLodSize { get; set; }
        public FoxBool EnableLod { get; set; }
    }
}
