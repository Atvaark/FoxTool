using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppTrapCheckIsInViewCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxEntityLink CheckLocator { get; set; }
        public FoxFloat CheckAreaSize { get; set; }
    }
}
