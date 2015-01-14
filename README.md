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
FoxTool -d file_path|folder_path
FoxTool -c file_path
```

Examples
--------
Decompiling a .fox2 file to .fox.

```
FoxTool -d file_path.fox2 
```

Decompiling all decompilable files in the folder to .fox

```
FoxTool -d folder_path
```

Compiling a .fox file to .bin

```
FoxTool -c file_path.fox
```
