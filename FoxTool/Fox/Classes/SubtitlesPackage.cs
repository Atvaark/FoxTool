using System.Collections.Generic;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class SubtitlesPackage
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        // name=subtitlesPackage
        public List<FoxFilePtr> SubtitlesPackageFoxFilePtrs { get; set; }
    }
}
