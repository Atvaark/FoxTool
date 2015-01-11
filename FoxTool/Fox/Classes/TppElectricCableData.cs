using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppElectricCableData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxFloat Size { get; set; }
        public FoxEntityLink Locator0 { get; set; }
        public FoxEntityLink Locator1 { get; set; }
        public FoxFilePtr PartsFile { get; set; }
        public FoxPath AnimFile { get; set; }
        public FoxFilePtr AnimFilePtr { get; set; }
    }
}
