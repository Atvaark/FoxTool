using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppHostageLocatorParameter
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxEntityPtr FileResources { get; set; }
        public FoxEntityLink CharacterFileResources { get; set; }
        public FoxUInt32 LifeMax { get; set; }
        public FoxBool IsReadyStatus { get; set; }
        public FoxString OptionTags { get; set; }
        public FoxEntityLink TargetTransformData { get; set; }
        public FoxString FormVariationKeyName { get; set; }
        public FoxUInt32 FormVariationRanomSeed { get; set; }
        public FoxString VoiceType { get; set; }
    }
}
