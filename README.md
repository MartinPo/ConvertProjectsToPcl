ConvertToPCL
=======================

Extension for Visual Studio to convert 4.5er projects to portable class libraries (PCL).

You can check which projects are not already converted and convert multiple projects to PCL.

Changes per project:
- Adjust '.csproj' file
- Remove from 'assembly.cs' the GUID and ComVisible attribute
- Remove references to .NET Framework Libraries

Features:

* Support .Net Frameworks 4.5.X

Available through Tools -> Convert Projects to PCL
