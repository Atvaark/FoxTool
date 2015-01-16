using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class NavxBounderLocator
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
        public FoxBool Enable { get; set; }
        public FoxString SceneName { get; set; }
        public FoxString WorldName { get; set; }
        public FoxInt32 Type { get; set; }
    }
}