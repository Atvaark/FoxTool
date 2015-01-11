using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DataSet : Data
    {
        public Dictionary<string, FoxEntityPtr> DataList { get; set; }
    }
}
