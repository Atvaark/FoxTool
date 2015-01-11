using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class GameScript : Data
    {
        // Static properties
        public FoxBool Enable { get; set; }
        public FoxPath ScriptPath { get; set; }
        public FoxEntityLink Variables { get; set; }
    }
}
