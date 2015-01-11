using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppTrapExecSoldierNoticeLightOffCallbackDataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public FoxString FuncName { get; set; }
        public FoxString LightSwitchCharacterId { get; set; }
        public List<FoxEntityLink> ReactionAreaBoxShapes { get; set; }
    }
}
