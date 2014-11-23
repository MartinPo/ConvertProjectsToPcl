/***************************************************************************

Copyright (c) Microsoft Corporation. All rights reserved.
This code is licensed under the Visual Studio SDK license terms.
THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

***************************************************************************/

using EnvDTE;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VsSDK.UnitTestLibrary;
using MLabs.ConvertToPcl;

namespace ConvertToPcl_UnitTests
{
    [TestClass()]
    public class PackageTest
    {
        [TestMethod()]
        public void FileTest()
        {
            var mig = new PclConverter(null);
            // mig.ChangeProjectFile(@"C:\DeleteMe\DailyStandupTool\Managers\Managers.csproj", "Profile7");
            var dte2 = (EnvDTE.DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE"); 
            Solution solution = dte2.Solution;
            foreach (Project project in solution.Projects)
            {
                 mig.ChangeAssemblyFile(project);
                //mig.RemoveFrameworkReference(project);
            }
        }

        [TestMethod()]
        public void CreateInstance()
        {
            ConvertToPclPackage package = new ConvertToPclPackage();
        }

        [TestMethod()]
        public void IsIVsPackage()
        {
            ConvertToPclPackage package = new ConvertToPclPackage();
            Assert.IsNotNull(package as IVsPackage, "The object does not implement IVsPackage");
        }

        [TestMethod()]
        public void SetSite()
        {
            // Create the package
            IVsPackage package = new ConvertToPclPackage() as IVsPackage;
            Assert.IsNotNull(package, "The object does not implement IVsPackage");

            // Create a basic service provider
            OleServiceProvider serviceProvider = OleServiceProvider.CreateOleServiceProviderWithBasicServices();

            // Site the package
            Assert.AreEqual(0, package.SetSite(serviceProvider), "SetSite did not return S_OK");

            // Unsite the package
            Assert.AreEqual(0, package.SetSite(null), "SetSite(null) did not return S_OK");
        }
    }
}
