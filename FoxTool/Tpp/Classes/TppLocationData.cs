using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppLocationData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxUInt16 LocationId { get; set; }
        public FoxPath ScriptPath { get; set; }
        public FoxFilePtr WeatherParametersFile { get; set; }
    }
}
