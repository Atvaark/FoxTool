using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class TppSpecialCharacterInterrogationData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath DataTablePath { get; set; }
        public Dictionary<string, FoxEntityLink> InterroParams { get; set; }
    }
}
