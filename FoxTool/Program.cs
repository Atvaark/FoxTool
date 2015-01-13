using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FoxTool.Fox;

namespace FoxTool
{
    public static class Program
    {
        private static readonly Dictionary<ulong, string> HashNameDictionary = new Dictionary<ulong, string>();

        private static void Main(string[] args)
        {
            foreach (
                var file in
                    GetFileList(new DirectoryInfo(@"E:\Games\Metal Gear Solid Ground Zeroes\Fpk\"), true,
                        new List<string> {".fox"}))
            {
                Console.WriteLine("Compiling {0}", file.FullName);
                using (FileStream fileStream = new FileStream(file.FullName, FileMode.Open))
                {
                    FoxConverter.CompileFox(fileStream);
                }
            }

            if (args.Length != 1)
            {
                ShowUsageInfo();
                return;
            }
            List<string> extensions = new List<string>
            {
                ".bnd",
                ".clo",
                ".des",
                ".evf",
                ".fox2",
                ".fsd",
                ".lad",
                ".parts",
                ".ph",
                ".phsd",
                ".sdf",
                ".sim",
                ".tgt",
                ".vdp",
                ".veh",
                ".vfxlf"
            };

            try
            {
                Console.WriteLine("Reading Dictionary.txt");
                ReadDictionary("Dictionary.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while reading the dictionary: {0}", e);
            }

            string path = args[0];
            if (File.Exists(path))
            {
                if (extensions.Contains(Path.GetExtension(path).ToLower()) == false)
                {
                    Console.WriteLine("The provided file is not decompilable.\n");
                    return;
                }

                var file = new FileInfo(path);
                Console.WriteLine("Decompiling {0}", file.FullName);
                DecompileFile(file);
            }
            else if (Directory.Exists(path))
            {
                foreach (var file in GetFileList(new DirectoryInfo(path), true, extensions))
                {
                    Console.WriteLine("Decompiling {0}", file.FullName);
                    DecompileFile(file);
                }
            }
            else
            {
                ShowUsageInfo();
            }
        }

        private static void ShowUsageInfo()
        {
            Console.WriteLine("FoxTool by Atvaark\n" +
                              "  A tool for decompiling the following types to Fox Engine XML .fox:\n" +
                              "  BND CLO DES EVF FOX2 FSD LAD PARTS PH PHSD SDF SIM TGT VDP VEH VFXLF\n" +
                              "Usage:\n" +
                              "  FoxTool file_path   - Decompile the file to .fox\n" +
                              "  FoxTool folder_path - Decompile all decompilable files in the folder to .fox\n");
        }

        private static void DecompileFile(FileInfo file)
        {
            string fileName = string.Format("{0}_{1}.fox", Path.GetFileNameWithoutExtension(file.Name),
                Path.GetExtension(file.Name).Replace(".", ""));
            string outputName = Path.Combine(file.DirectoryName, fileName);
            using (FileStream input = new FileStream(file.FullName, FileMode.Open))
            using (FileStream output = new FileStream(outputName, FileMode.Create))
            {
                try
                {
                    var foxFile = FoxFile.ReadFoxFile(input, HashNameDictionary);
                    FoxConverter.DecompileFox(foxFile, output);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error decompiling {0}: {1}", file.FullName, e);
                }
            }
        }

        private static List<FileInfo> GetFileList(DirectoryInfo fileDirectory, bool recursively, List<string> extensions)
        {
            List<FileInfo> files = new List<FileInfo>();
            if (recursively)
            {
                foreach (var directory in fileDirectory.GetDirectories())
                {
                    files.AddRange(GetFileList(directory, recursively, extensions));
                }
            }
            files.AddRange(
                fileDirectory.GetFiles()
                    .Where(f => extensions.Contains(f.Extension, StringComparer.CurrentCultureIgnoreCase)));
            return files;
        }

        private static void ReadDictionary(string path)
        {
            foreach (var line in File.ReadAllLines(path))
            {
                ulong hash = HashFileName(line);
                if (HashNameDictionary.ContainsKey(hash) == false)
                {
                    HashNameDictionary.Add(hash, line);
                }
            }
        }

        private static ulong HashFileName(string text)
        {
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = (uint) ((text[0]) << 16) + (uint) text.Length;
            ulong hash2 = CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF;
            return hash2;
        }
    }
}
