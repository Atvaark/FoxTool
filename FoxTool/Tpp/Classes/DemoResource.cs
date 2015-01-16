using System.Collections.Generic;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Tpp.Classes
{
    public class DemoResource
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxBool Enable { get; set; }
        public FoxString DemoIdentifierName { get; set; }
        public List<FoxString> DemoIdentifierKey { get; set; }
        public FoxUInt32 StreamBufferSizeInKbytes { get; set; }
        public FoxUInt32 SystemPacketSizeInKbytes { get; set; }
        public FoxUInt32 SystemPacketNum { get; set; }
        public FoxUInt32 SoundPacketSizeInKbytes { get; set; }
        public FoxUInt32 SoundPacketNum { get; set; }
        public FoxUInt32 DemoPacketSizeInKbytes { get; set; }
        public FoxUInt32 DemoPacketNum { get; set; }
    }
}
