using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class ObjectBrush
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
        public List<FoxEntityHandle> PluginHandle { get; set; }
        public List<FoxString> BlockDataName { get; set; }
        public FoxPath FilePath { get; set; }
        public FoxPath LoadFilePath { get; set; }
        public FoxFilePtr ObrFile { get; set; }
        public FoxUInt32 NumBlocks { get; set; }
    }
}
