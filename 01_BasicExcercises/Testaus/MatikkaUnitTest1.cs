using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;

namespace Testaus
{
    [TestClass]
    public class MatikkaUnitTest1
    {
        [TestMethod]
        [DataRow (1, 1, 0)]
        [DataRow (1, 1, 1)]
        [DataRow(10, 5, -10)]
        public void MiinusLasku_KahdellaKokonaisLuvulla_PalauttaaKokonaisLuvun(int luku1, int luku2, int tulos)
        {
            int OdotettuTulos = luku1 - luku2;

            // Assert
            Assert.AreEqual(tulos, OdotettuTulos);
        }

        [TestMethod]
        public void Potenssi_Yhdell‰Kokonaisluvulla_PalauttaaPotenssin()
        {   
            //arrange
            int luku3 = 5;
            //act
            int tulos1 = Laskin.Potenssi(luku3);
            Assert.AreEqual(25, tulos1);
        }

    }
}