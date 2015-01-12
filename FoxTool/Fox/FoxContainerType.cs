using System.Xml.Serialization;

namespace FoxTool.Fox
{
    public enum FoxContainerType
    {
        [XmlEnum("StaticArray")]
        StaticArray = 0,
        [XmlEnum("DynamicArray")]
        DynamicArray = 1,
        [XmlEnum("StringMap")]
        StringMap = 2,
        [XmlEnum("List")]
        List = 3
    }
}
