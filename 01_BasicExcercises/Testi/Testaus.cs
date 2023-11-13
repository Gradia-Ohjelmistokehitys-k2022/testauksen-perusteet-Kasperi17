using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;





namespace FileOperations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIsNotEmpty()
        {
            //Arrange
            List<string> systemConfig = new List<string>();
    
            string winDir = "C:\\Windows";
            string path = "\\system.ini";
            //Act
            systemConfig = File.ReadFile(systemConfig, winDir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count > 0);

        }


    }
}
