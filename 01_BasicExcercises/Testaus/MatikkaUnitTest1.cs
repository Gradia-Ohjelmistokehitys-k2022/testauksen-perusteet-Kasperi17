using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;

namespace Testaus
{
    [TestClass]
    public class MatikkaUnitTest1
    {
        [TestMethod]
        public void MiinusLasku_KahdellaKokonaisLuvulla_PalauttaaKokonaisLuvun()
        {
            //arrange
            int luku1 = 0;
            int luku2 = 1;
            //act
            int tulos = Laskin.MiinusLasku(luku1, luku2);
            //assert
            Assert.AreEqual(-1, tulos);
        }
        [TestMethod]
        public void Potenssi_Yhdell‰Kokonaisluvulla_PalauttaaPotenssin()
        {   
            //arrange
            int luku3 = 101;
            //act
            int tulos1 = Laskin.Potenssi(luku3);
            Assert.AreEqual(10201, tulos1);
        }

    }
}