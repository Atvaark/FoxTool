using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppMissionParameterData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr MissionSetupFile { get; set; }
        public FoxBool Enable { get; set; }
    }
}
