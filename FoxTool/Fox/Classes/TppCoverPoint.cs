using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppCoverPoint
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
        public FoxUInt8 Tags { get; set; }
        public FoxEntityLink UserData { get; set; }
        public FoxBool IsLeftOpen { get; set; }
        public FoxBool IsRightOpen { get; set; }
        public FoxBool IsUpOpen { get; set; }
        public FoxBool IsStandable { get; set; }
        public FoxBool IsUnVaultable { get; set; }
        public FoxBool IsUseVip { get; set; }
    }
}
