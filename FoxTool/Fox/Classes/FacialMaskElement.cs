using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class FacialMaskElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        public List<FoxString> SkelList { get; set; }
        public List<FoxEntityPtr> ShaderList { get; set; }
    }
}
