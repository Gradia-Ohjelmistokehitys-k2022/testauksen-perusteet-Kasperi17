using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;
using Testaus;





namespace Testaus
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
            systemConfig = FileOperations.ReadFile(systemConfig, winDir, path);
            //Assert
            Assert.IsTrue(systemConfig.Count > 0);


        }
        [TestMethod]
        public void ReadFile_If_FileNotFound_ThrowsException()
        {
            List<string> systemConfig = new List<string>();
            string path = "C:\\Windows";
            string moi = "\\daåkdapodkapdkja";
            // Act and Assert
            Assert.ThrowsException<FileNotFoundException>(() =>
            {
                systemConfig = FileOperations.ReadFile(new List<string>(), path, moi);
            
            });

        }
        [TestMethod]
        public void PrintFile_o()
        {   //arrange
            List<string> systemConfig = new List<string> { "Kullervo", "milo", "anus.antti" };
            //act
            FileOperations.PrintFile(systemConfig);
            //assert
            Assert.IsTrue(systemConfig.Count > 0);
        }











        /*[TestMethod]
        public void FileExists_ReturnsTrueIfFileExists()
        {
                // Arrange
                string path = @"F:\Ohjelmointi tehtävät\moi.txt";

                // Act
                bool fileExists = File.FileOperations.FileExists(path);

                // Assert
                Assert.IsTrue(fileExists);


        }*/



    }
    
}
