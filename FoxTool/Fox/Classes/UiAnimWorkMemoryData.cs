using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class UiAnimWorkMemoryData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt32 NodeAnimNum { get; set; }
        public FoxUInt32 ShaderAnimNum { get; set; }
        public FoxUInt32 VertexAnimNum { get; set; }
    }
}
