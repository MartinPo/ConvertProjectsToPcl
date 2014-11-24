ConvertToPCL
=======================

Extension for Visual Studio (VSIX) to convert 4.5er projects to portable class libraries (PCL).
Select one or more projects, choose target framework and convert them to PCL. 
Hint: Some target framework needs additional setups.

Changes per project:
- Add new entries in '.csproj' file
- Remove from 'assembly.cs' the GUID and ComVisible attribute
- Remove references to .NET Framework Libraries which are part of the portable Framework

Features:

* Support .Net Frameworks 4.5.X


Hosted in Visual Studio Gallery
https://visualstudiogallery.msdn.microsoft.com/e2dcdf06-444d-4501-8dae-732e76bc94aa?SRC=Home


Thanks 
https://github.com/VHQLabs/TargetFrameworkMigrator
for sharing her code