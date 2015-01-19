FoxTool
========
A tool for compiling and decompiling Fox Engine XML files.
Compiled XML files have these file extensions:
BND CLO DES EVF FOX2 FSD LAD PARTS PH PHSD SDF SIM TGT VDP VEH VFXLF

Requirements
--------
```
Microsoft .NET Framework 4.5 
```

Usage
--------
```
FoxTool [-d|-c] file_path|folder_path
```

Examples
--------

Compiling an XML file
```
FoxTool file_path.XML
FoxTool -c file_path.XML
```

Decompiling a file to XML
```
FoxTool file_path
FoxTool -d file_path
```

Decompiling all decompilable files in the folder to XML
```
FoxTool folder_path
FoxTool -d folder_path
```
