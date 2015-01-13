using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TransformEntity : DataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        // name=transform_scale
        public FoxVector3 TransformScale { get; set; }
        // name=transform_rotation_quat
        public FoxQuat TransformRotationQuat { get; set; }
        // name=transform_translation
        public FoxVector3 TransformTranslation { get; set; }
    }
}
