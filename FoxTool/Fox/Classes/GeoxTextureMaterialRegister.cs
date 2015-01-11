using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoxTextureMaterialRegister
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityLink MaterialLink { get; set; }
        public FoxString CollisionMaterialName { get; set; }
        public FoxString CollisionColorName { get; set; }
    }
}
