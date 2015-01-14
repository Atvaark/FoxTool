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
            if (args.Length != 2)
            {
                ShowUsageInfo();
                return;
            }

            switch (args[0])
            {
                case "-c":
                    CompileFile(args[1]);
                    break;
                case "-d":
                    DecompileFile(args[1]);
                    break;
                default:
                    ShowUsageInfo();
                    return;
            }

        }

        private static void CompileFile(string path)
        {
            string outFileName = Path.Combine(Path.GetDirectoryName(path), string.Format("{0}.bin", Path.GetFileNameWithoutExtension(path)));
            using (FileStream input = new FileStream(path, FileMode.Open))
            using (FileStream output = new FileStream(outFileName, FileMode.Create))
            {
                try
                {
                    FoxConverter.CompileFox(input, output);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error compiling {0}: {1}", path, e);
                }
            }
        }

        private static void ShowUsageInfo()
        {
            Console.WriteLine("FoxTool by Atvaark\n" +
                              "  A tool for compiling and decompiling Fox Engine XML files." +
                              "Information:\n" +
                              "  Compiled XML files have these file extensions:\n" +
                              "  BND CLO DES EVF FOX2 FSD LAD PARTS PH PHSD SDF SIM TGT VDP VEH VFXLF\n" +
                              "Usage:\n" +
                              "  FoxTool -d file_path   - Decompile the file to .fox\n" +
                              "  FoxTool -d folder_path - Decompile all decompilable files in the folder to .fox\n" +
                              "  FoxTool -c file_path   - Compile the file to .bin");
        }

        private static void DecompileFile(string path)
        {
            List<string> decompilableExtensions = new List<string>
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
                return;
            }

            if (File.Exists(path))
            {
                if (decompilableExtensions.Contains(Path.GetExtension(path).ToLower()) == false)
                {
                    Console.WriteLine("The provided file is not decompilable.\n");
                    return;
                }

                var file = new FileInfo(path);
                Console.WriteLine("Decompiling {0}", file.FullName);
                try
                {
                    DecompileFile(file);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error decompiling {0}: {1}", path, e);
                }
            }
            else if (Directory.Exists(path))
            {
                foreach (var file in GetFileList(new DirectoryInfo(path), true, decompilableExtensions))
                {
                    Console.WriteLine("Decompiling {0}", file.FullName);
                    try
                    {
                        DecompileFile(file);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error decompiling {0}: {1}", path, e);
                    }
                }
            }
            else
            {
                ShowUsageInfo();
            }
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
                ulong hash = Hashing.HashString(line);
                if (HashNameDictionary.ContainsKey(hash) == false)
                {
                    HashNameDictionary.Add(hash, line);
                }
            }
        }
    }
}
