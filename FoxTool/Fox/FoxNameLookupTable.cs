using System.Collections.Generic;

namespace FoxTool.Fox
{
    public class FoxNameLookupTable
    {
        public FoxNameLookupTable() : this(new Dictionary<ulong, string>())
        {
        }

        public FoxNameLookupTable(Dictionary<ulong, string> globalLookupTable)
            : this(globalLookupTable, new Dictionary<ulong, string>())
        {
        }

        public FoxNameLookupTable(Dictionary<ulong, string> globalLookupTable,
            Dictionary<ulong, string> localLookupTable)
        {
            GlobalLookupTable = globalLookupTable;
            LocalLookupTable = localLookupTable;
        }

        public Dictionary<ulong, string> GlobalLookupTable { get; set; }
        public Dictionary<ulong, string> LocalLookupTable { get; set; }

        public string Lookup(ulong hash)
        {
            string result;
            if (LocalLookupTable.TryGetValue(hash, out result))
                return result;
            if (GlobalLookupTable.TryGetValue(hash, out result))
                return result;
            return null;
        }
    }
}
