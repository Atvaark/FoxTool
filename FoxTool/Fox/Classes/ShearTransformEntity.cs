using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ShearTransformEntity : DataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        // name=shearTransform_shear
        public FoxVector3 ShearTransformShear { get; set; }
    }
}
