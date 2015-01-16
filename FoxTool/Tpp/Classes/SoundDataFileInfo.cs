using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class SoundDataFileInfo
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString LoadBanks { get; set; }
        public FoxString PrepareBanks { get; set; }
        public FoxString PrepareEvents { get; set; }
    }
}
