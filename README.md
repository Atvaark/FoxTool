FoxTool
========
A tool for compiling and decompiling Fox Engine XML files.
Compiled XML files have these file extensions:

Extension     | Content
------------- | -----------
BND           | Graph Bounder Data
CLO           | Sim Cloth Setting
DES           | Destruction
EVF           | Event
FOX2          | Scene
FSD           | Facial Settings Data
LAD           | Lip Adjust Data
PARTS         | Model Description
PH            | Physics Object Description
PHSD          | Physics Sound Parameter
SDF           | Sound Data File Info
SIM           | Simulation Object
TGT           | Geometry Target Description
VDP           | Vehicle Driving Parameter
VEH           | Vehicle
VFXLF         | Visual Effects Lense Flare

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
