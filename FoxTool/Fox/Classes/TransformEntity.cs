using FoxTool.Fox.Types;

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
