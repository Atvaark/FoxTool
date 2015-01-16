using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class TppAmbientParameter
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString AmbientEvent { get; set; }
        public FoxString ObjectRtpcName { get; set; }
        public FoxFloat ObjectRtpcValue { get; set; }
        public FoxFloat AuxSends { get; set; }
        public FoxFloat DryVolume { get; set; }
    }
}
