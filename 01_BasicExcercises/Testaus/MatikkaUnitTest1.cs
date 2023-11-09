using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography.X509Certificates;

namespace Testaus
{
    [TestClass]
    public class MatikkaUnitTest1
    {
        [TestMethod]
        [DataRow (1, 1, 0)]
        [DataRow (100, 50, 50)]
        [DataRow(10, 20, -10)]
        public void MiinusLasku_KahdellaKokonaisLuvulla_PalauttaaKokonaisLuvun(int luku1, int luku2, int tulos)
        {
            /*arrange
            int luku1 = 0;
            int luku2 = 1;
            //act
            int tulos = Laskin.MiinusLasku(luku1, luku2);
            //assert
            Assert.AreEqual(-1, tulos);
            */

            int OdotettuTulos = Laskin.MiinusLasku(luku1, luku2);
            Assert.AreEqual(tulos, OdotettuTulos);
            
        }
        [TestMethod]
        [DataRow(5, 25)]
        [DataRow(3, 9)]
        [DataRow(4, 16)]
        [ExpectedException(typeof(ArgumentException))]
        public void Potenssi_Yhdell‰Kokonaisluvulla_PalauttaaPotenssin(int luku, int tulos)
        {   
            
            
            int OdotetuTulos = Laskin.Potenssi(luku);
            Assert.AreEqual(tulos, OdotetuTulos);
        }
        [TestMethod]
        [DataRow (54, 7.3484692283495345)]
        public void Neliojuuri_KokonaisLuvulla_PalauttaaNelioJuuren(int luku, double tulos)
        {
            double OdotettuTulos = Laskin.NelioJuuri(luku);
            Assert.AreEqual(tulos, OdotettuTulos);
        }

    }
}