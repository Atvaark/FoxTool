using FoxTool.Fox.Types;

namespace FoxTool.Fox.Classes
{
    public class DemoStreamAnimation
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxPath StreamPath { get; set; }
        public FoxUInt32 DemoLength { get; set; }
        public FoxInt32 LocatorTypes { get; set; }
        public FoxInt32 CameraTypes { get; set; }
        public FoxFilePtr ModelFiles { get; set; }
        public FoxFilePtr HelpBoneFiles { get; set; }
        public FoxFilePtr PartsFiles { get; set; }
        public FoxString ModelPartsDictionary { get; set; }
        public FoxUInt32 UpdateJobCount { get; set; }
        public FoxPath ModelProxyPaths { get; set; }
        public FoxPath PartsProxyPaths { get; set; }
    }
}
