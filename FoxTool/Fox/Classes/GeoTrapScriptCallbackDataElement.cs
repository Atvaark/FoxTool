using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GeoTrapScriptCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxFilePtr ScriptFile { get; set; }
        public FoxBool DidAddParam { get; set; }
    }
}
