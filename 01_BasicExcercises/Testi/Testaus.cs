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
        [TestMethod]
        public void ReadFile_ReturnsListOfSettings_IfFileIstEmpty()
        {
            List<string> systemConfig = new List<string>();
            string path = "C:\\testi";
            string moi = "\\pekka.txt";
            // Luo tyhj‰ tiedosto tai k‰yt‰ olemassa olevaa tyhj‰‰ tiedostoa

            // Act
            systemConfig = File.ReadFile(systemConfig, moi, path);

            // Assert
            Assert.IsTrue(systemConfig.Count == 0);


        }
























        /*[TestMethod]
        public void FileExists_ReturnsTrueIfFileExists()
        {
                // Arrange
                string path = @"F:\Ohjelmointi teht‰v‰t\moi.txt";

                // Act
                bool fileExists = File.FileOperations.FileExists(path);

                // Assert
                Assert.IsTrue(fileExists);


        }*/



    }
    
}
