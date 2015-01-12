using System.Xml.Serialization;

namespace FoxTool.Fox
{
    /// <summary>
    ///     fox::PropertyInfo::Type
    /// </summary>
    public enum FoxDataType
    {
        [XmlEnum("int8")]
        FoxInt8 = 0,
        [XmlEnum("uint8")]
        FoxUInt8 = 1,
        [XmlEnum("int16")]
        FoxInt16 = 2,
        [XmlEnum("uint16")]
        FoxUInt16 = 3,
        [XmlEnum("int32")]
        FoxInt32 = 4,
        [XmlEnum("uint32")]
        FoxUInt32 = 5,
        [XmlEnum("int64")]
        FoxInt64 = 6,
        [XmlEnum("uint64")]
        FoxUInt64 = 7,
        [XmlEnum("float")]
        FoxFloat = 8,
        [XmlEnum("double")]
        FoxDouble = 9,
        [XmlEnum("bool")]
        FoxBool = 10,
        [XmlEnum("string")]
        FoxString = 11,
        [XmlEnum("Path")]
        FoxPath = 12,
        [XmlEnum("EntityPtr")]
        FoxEntityPtr = 13,
        [XmlEnum("Vector3")]
        FoxVector3 = 14,
        [XmlEnum("Vecto4")]
        FoxVector4 = 15,
        [XmlEnum("Quat")]
        FoxQuat = 16,
        [XmlEnum("Matrix3")]
        FoxMatrix3 = 17,
        [XmlEnum("Matrix4")]
        FoxMatrix4 = 18,
        [XmlEnum("Color")]
        FoxColor = 19,
        [XmlEnum("FilePtr")]
        FoxFilePtr = 20,
        [XmlEnum("EntityHandle")]
        FoxEntityHandle = 21,
        [XmlEnum("EntityLink")]
        FoxEntityLink = 22
    }
}
