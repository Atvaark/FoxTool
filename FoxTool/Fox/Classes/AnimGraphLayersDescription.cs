using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class AnimGraphLayersDescription : Data
    {
        // Static array
        // Dynamic array
        public List<FoxEntityPtr> Layers { get; set; }
    }
}
