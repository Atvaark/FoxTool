using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppDefaultParameter
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxString Id { get; set; }
        public FoxEntityPtr Params { get; set; }
        public FoxString GroupName { get; set; }
    }
}
