using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppVfxFileLoader
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFilePtr VfxFiles { get; set; }
        public FoxFilePtr GeoMaterialFiles { get; set; }
        public FoxFilePtr OtherFiles { get; set; }
    }
}
