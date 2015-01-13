using System;

namespace FoxTool
{
    internal static class Hashing
    {
        internal static ulong HashString(string text)
        {
            if (String.IsNullOrEmpty(text)) return 0xFFFFFFFFFFFF; // TODO: Remove dummy hash value.
            // TODO: Check how fox engine handles text with length 0.
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = (uint) ((text[0]) << 16) + (uint) text.Length;
            return CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF;
        }
    }
}
