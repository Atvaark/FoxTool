using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppUICommonBootData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr UiFile { get; set; }
        public FoxString WindowName { get; set; }
        public FoxInt32 Dependence { get; set; }
        public FoxInt32 PauseFlag { get; set; }
    }
}
