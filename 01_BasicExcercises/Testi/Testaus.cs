using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;
using FileOperations;



namespace FileOperations
{   
   
    
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
            {
                //Arrange
                List<string> systemConfig;
                string winDir = "C:\\Windows";
                string path = "\\system.ini";
                //Act
                systemConfig = FileOperations.UnitTest1.ReadFile(systemConfig, windir, path);
                //Assert
                Assert.IsTrue(systemConfig.Count < 0);

            }

        }
}