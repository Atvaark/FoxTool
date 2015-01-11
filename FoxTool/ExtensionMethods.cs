using System;
using System.IO;
using System.Linq;
using FoxTool.Fox;

namespace FoxTool
{
    internal static class ExtensionMethods
    {
        internal static void Skip(this BinaryReader reader, int count)
        {
            reader.BaseStream.Seek(count, SeekOrigin.Current);
        }

        internal static void WriteZeros(this BinaryWriter writer, int count)
        {
            byte[] zeros = new byte[count];
            writer.Write(zeros);
        }

        internal static void AlignRead(this Stream input, int alignment)
        {
            long alignmentRequired = input.Position%alignment;
            if (alignmentRequired > 0)
                input.Position += alignment - alignmentRequired;
        }

        internal static void AlignWrite(this Stream output, int alignment, byte data)
        {
            long alignmentRequired = output.Position%alignment;
            if (alignmentRequired > 0)
            {
                byte[] alignmentBytes = Enumerable.Repeat(data, (int) (alignment - alignmentRequired)).ToArray();
                output.Write(alignmentBytes, 0, alignmentBytes.Length);
            }
        }

        internal static string ReadString(this BinaryReader binaryReader, int count)
        {
            return new string(binaryReader.ReadChars(count));
        }


        internal static bool IsPrintable(this string s)
        {
            return s.Any(c => char.IsControl(c) || char.IsHighSurrogate(c) || char.IsLowSurrogate(c)) == false;
        }

        internal static string ToXmlName(this FoxDataType type)
        {
            switch (type)
            {
                case FoxDataType.FoxInt8:
                    return "int8";
                case FoxDataType.FoxUInt8:
                    return "uint8";
                case FoxDataType.FoxInt16:
                    return "int16";
                case FoxDataType.FoxUInt16:
                    return "uint16";
                case FoxDataType.FoxInt32:
                    return "int32";
                case FoxDataType.FoxUInt32:
                    return "uint32";
                case FoxDataType.FoxInt64:
                    return "int64";
                case FoxDataType.FoxUInt64:
                    return "uint64";
                case FoxDataType.FoxFloat:
                    return "float";
                case FoxDataType.FoxDouble:
                    return "double";
                case FoxDataType.FoxBool:
                    return "bool";
                case FoxDataType.FoxString:
                    return "String";
                case FoxDataType.FoxPath:
                    return "Path";
                case FoxDataType.FoxEntityPtr:
                    return "EntityPtr";
                case FoxDataType.FoxVector3:
                    return "Vector3";
                case FoxDataType.FoxVector4:
                    return "Vector4";
                case FoxDataType.FoxQuat:
                    return "Quat";
                case FoxDataType.FoxMatrix3:
                    return "Matrix3";
                case FoxDataType.FoxMatrix4:
                    return "Matrix4";
                case FoxDataType.FoxColor:
                    return "Color";
                case FoxDataType.FoxFilePtr:
                    return "FilePtr";
                case FoxDataType.FoxEntityHandle:
                    return "EntityHandle";
                case FoxDataType.FoxEntityLink:
                    return "EntityLink";
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }
    }
}
